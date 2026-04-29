using MyLibreriaVoto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupo3_Proyecto
{

    public partial class frmVotacion : Form
    {


        private readonly string _cedulaVotante;
        private readonly int _idTipoEleccion; 
        private Timer _timer;
        private int _segundosRestantes = 60;


        public frmVotacion(string cedulaVotante, int idTipoEleccion)
        {
            InitializeComponent();

            _cedulaVotante = cedulaVotante;
            _idTipoEleccion = idTipoEleccion;

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            try
            {
                int? idCandidato = ObtenerCandidatoSeleccionado();
                if (idCandidato == null)
                {
                    MessageBox.Show("Debe seleccionar un candidato (marcar la X).", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            
                DialogResult resp = MessageBox.Show(
                    "¿Desea confirmar su voto?\n(Seleccione NO si desea corregir la escogencia)",
                    "Confirmar voto",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resp == DialogResult.No)
                    return;


              
                string sqlIns =
                    "INSERT INTO Votacion (Cedula, FechaHora, IdCandidato, IdTipoEleccion) " +
                    "VALUES (@cedula, @fecha, @idCandidato, @tipo)";

                Utilidades.ejecutarAccion(sqlIns,
                    new SqlParameter("@cedula", _cedulaVotante),
                    new SqlParameter("@fecha", DateTime.Now),
                    new SqlParameter("@idCandidato", idCandidato.Value),
                    new SqlParameter("@tipo", _idTipoEleccion));

                _timer.Stop();

                MessageBox.Show("Voto registrado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close(); 
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error SQL al registrar el voto: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el voto: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void frmVotacion_Load(object sender, EventArgs e)
        {          


            lblTipoEleccion.Text = (_idTipoEleccion == 1) ? "Votación Presidencial" : "Votación Diputados";

           
            if (YaVotoEsteTipo())
            {
                MessageBox.Show("Esta votación ya se efectuó.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.BeginInvoke((Action)(() => this.Close()));
                return;
            }

          
            ConfigurarGrid();

            dgvCandidatos.DataError += (s, e) => { e.ThrowException = false; };

            CargarCandidatos();

           
            IniciarTimer();




        }

        private void dgvCandidatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvCandidatos.Columns[e.ColumnIndex].Name != "Seleccion") return;

           
            foreach (DataGridViewRow r in dgvCandidatos.Rows)
            {
                if (r.Index != e.RowIndex)
                    r.Cells["Seleccion"].Value = false;
            }

            dgvCandidatos.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvCandidatos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
                 
        {
        
            if (dgvCandidatos.IsCurrentCellDirty)
                dgvCandidatos.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvCandidatos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvCandidatos.Columns[e.ColumnIndex].Name != "Seleccion") return;

            bool marcado = Convert.ToBoolean(dgvCandidatos.Rows[e.RowIndex].Cells["Seleccion"].Value);

        
            if (marcado)
            {
                foreach (DataGridViewRow r in dgvCandidatos.Rows)
                {
                    if (r.Index != e.RowIndex)
                        r.Cells["Seleccion"].Value = false;
                }
            }
        }
        


     

        private void ConfigurarGrid()
        {
            dgvCandidatos.AutoGenerateColumns = false;
            dgvCandidatos.Columns.Clear();
            dgvCandidatos.AllowUserToAddRows = false;
            dgvCandidatos.RowTemplate.Height = 70;
            dgvCandidatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCandidatos.MultiSelect = false;

            // ✅ Permitimos edición (pero luego bloqueamos todo excepto la X)
            dgvCandidatos.ReadOnly = false;

            var colBandera = new DataGridViewImageColumn
            {
                Name = "BanderaImg",
                HeaderText = "Bandera",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 90
            };
            dgvCandidatos.Columns.Add(colBandera);

            var colFoto = new DataGridViewImageColumn
            {
                Name = "FotoImg",
                HeaderText = "Foto",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 90
            };
            dgvCandidatos.Columns.Add(colFoto);

            dgvCandidatos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NombreCompleto",
                HeaderText = "Candidato",
                DataPropertyName = "NombreCompleto",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true
            });

            dgvCandidatos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NombrePartido",
                HeaderText = "Partido",
                DataPropertyName = "NombrePartido",
                Width = 180,
                ReadOnly = true
            });

            var colSel = new DataGridViewCheckBoxColumn
            {
                Name = "Seleccion",
                HeaderText = "X",
                Width = 40,
                ReadOnly = false 
            };
            dgvCandidatos.Columns.Add(colSel);

       
            foreach (DataGridViewColumn col in dgvCandidatos.Columns)
                col.ReadOnly = col.Name != "Seleccion";

            dgvCandidatos.CellFormatting += dgvCandidatos_CellFormatting;

            dgvCandidatos.CurrentCellDirtyStateChanged += dgvCandidatos_CurrentCellDirtyStateChanged;
            dgvCandidatos.CellValueChanged += dgvCandidatos_CellValueChanged;
        }


        private void CargarCandidatos()
        {

            string sql =
                            "SELECT c.IdCandidato, " +
                            "       (ISNULL(c.Nombre,'') + ' ' + ISNULL(c.Apellidos,'')) AS NombreCompleto, " + 
                            "       ISNULL(p.NombrePartido,'') AS NombrePartido, " +
                            "       p.Bandera, c.Foto " +
                            "FROM Candidatos c " +
                            "INNER JOIN PartidosPoliticos p ON c.IdPartido = p.IdPartido " +
                            "WHERE c.IdTipoEleccion = @tipo";

            DataSet ds = Utilidades.ejecutar(sql,
                new SqlParameter("@tipo", _idTipoEleccion));

            dgvCandidatos.DataSource = ds.Tables[0];

        }


        private void dgvCandidatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var rowView = dgvCandidatos.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (rowView == null) return;

            if (dgvCandidatos.Columns[e.ColumnIndex].Name == "BanderaImg")
            {
                e.Value = CargarImagenLocal(rowView["Bandera"]?.ToString());
            }
            else if (dgvCandidatos.Columns[e.ColumnIndex].Name == "FotoImg")
            {
                e.Value = CargarImagenLocal(rowView["Foto"]?.ToString());
            }
        
        }

        private Image CargarImagenLocal(string ruta)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ruta))
                    return null;

                
                string rutaCompleta = Path.Combine(Application.StartupPath, "Imagenes", ruta);

                if (!File.Exists(rutaCompleta))
                    return null;

                using (FileStream fs = new FileStream(rutaCompleta, FileMode.Open, FileAccess.Read))
                using (Image imgTemp = Image.FromStream(fs))
                {
                    return (Image)imgTemp.Clone();
                }
            }
            catch
            {
                return null;
            }
        }

        private bool YaVotoEsteTipo()
        {
            string sql = "SELECT COUNT(*) FROM Votacion WHERE Cedula = @cedula AND IdTipoEleccion = @tipo";
            object result = Utilidades.ejecutarEscalar(sql,
                new SqlParameter("@cedula", _cedulaVotante),
                new SqlParameter("@tipo", _idTipoEleccion));

            int n = Convert.ToInt32(result);
            return n > 0;
        }


        private void IniciarTimer()
        {
            lblTiempo.Text = "Tiempo restante: 60";

            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += (s, e) =>
            {
                _segundosRestantes--;
                lblTiempo.Text = "Tiempo restante: " + _segundosRestantes;

                if (_segundosRestantes <= 0)
                {
                    _timer.Stop();

                    MessageBox.Show("Se agotó el tiempo. Debe iniciar sesión nuevamente.", "Tiempo agotado",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    Application.Restart();
                }
            };

            _timer.Start();
        }


        private int? ObtenerCandidatoSeleccionado()
        {
            foreach (DataGridViewRow r in dgvCandidatos.Rows)
            {
                bool sel = r.Cells["Seleccion"].Value != null && (bool)r.Cells["Seleccion"].Value;
                if (sel)
                {
                    var drv = r.DataBoundItem as DataRowView;
                    return Convert.ToInt32(drv["IdCandidato"]);
                }
            }
            return null;
        }


    }
}
