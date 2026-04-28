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
    public partial class frmPartidosPoliticos : Form
    {
        private bool _existe = false;
        private bool _cargando = false;
        public frmPartidosPoliticos()
        {
            InitializeComponent();
        }

        private void frmPartidosPoliticos_Load(object sender, EventArgs e)
        {

            CargarPartidos();

            ConfigurarGrid();
            CargarPartidos();
            Limpiar(false);



        }


        private void ConfigurarGrid()
        {
            dgvPartidos.ReadOnly = true;
            dgvPartidos.AllowUserToAddRows = false;
            dgvPartidos.AllowUserToDeleteRows = false;
            dgvPartidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPartidos.MultiSelect = false;
            dgvPartidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPartidos.RowHeadersVisible = false;
        }



        private void CargarPartidos()
        {

            DataSet ds = Utilidades.ejecutar(
                            "SELECT IdPartido, NombrePartido, Bandera FROM PartidosPoliticos ORDER BY IdPartido");

            dgvPartidos.DataSource = ds.Tables[0];

            // Ocultar Id si no quieres verlo (opcional)
            if (dgvPartidos.Columns.Contains("IdPartido"))
                dgvPartidos.Columns["IdPartido"].Visible = true; // ponlo false si prefieres ocultarlo

        }


        private void dgvPartidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            DataGridViewRow r = dgvPartidos.Rows[e.RowIndex];
            _cargando = true;

            txtIdPartido.Text = r.Cells["IdPartido"].Value.ToString();
            // Al asignar txtIdPartido, se ejecuta TextChanged y carga el resto

            _cargando = false;

            // Forzamos cargar directamente por seguridad:
            txtIdPartido_TextChanged(sender, e);

        }

        private void btnBuscarImagen_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imágenes|*.jpg;*.png;*.jpeg;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtRutaBandera.Text = ofd.FileName;
                CargarImagen(ofd.FileName);
            }



        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string nombre = txtNombrePartido.Text.Trim();
            string bandera = txtRutaBandera.Text.Trim();
            string txtId = txtIdPartido.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Debe ingresar el nombre del partido.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_existe)
                {
                    // UPDATE requiere ID válido
                    if (!int.TryParse(txtId, out int id))
                    {
                        MessageBox.Show("ID inválido para modificar.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string sql =
                        "UPDATE PartidosPoliticos SET NombrePartido=@n, Bandera=@b WHERE IdPartido=@id";

                    Utilidades.ejecutarAccion(sql,
                        new SqlParameter("@id", id),
                        new SqlParameter("@n", nombre),
                        new SqlParameter("@b", (object)bandera ?? DBNull.Value)
                    );

                    MessageBox.Show("Partido modificado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // INSERT (IdPartido es Identity, NO lo insertamos)
                    string sql =
                        "INSERT INTO PartidosPoliticos (NombrePartido, Bandera) VALUES (@n, @b); " +
                        "SELECT SCOPE_IDENTITY();";

                    object nuevoIdObj = Utilidades.ejecutarEscalar(sql,
                        new SqlParameter("@n", nombre),
                        new SqlParameter("@b", (object)bandera ?? DBNull.Value)
                    );

                    int nuevoId = Convert.ToInt32(nuevoIdObj);
                    MessageBox.Show($"Partido creado correctamente. ID asignado: {nuevoId}", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _cargando = true;
                    txtIdPartido.Text = nuevoId.ToString();
                    _cargando = false;

                    _existe = true;
                }

                CargarPartidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            string txtId = txtIdPartido.Text.Trim();

            if (!int.TryParse(txtId, out int id))
            {
                MessageBox.Show("Ingrese un ID válido para eliminar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Eliminar este partido por ID?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                string sql = "DELETE FROM PartidosPoliticos WHERE IdPartido=@id";
                int filas = Utilidades.ejecutarAccion(sql, new SqlParameter("@id", id));

                if (filas > 0)
                {
                    MessageBox.Show("Partido eliminado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró un partido con ese ID.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                CargarPartidos();
                Limpiar(true);
            }
            catch (Exception ex)
            {
                // Si hay FK con Candidatos, aquí va a fallar (y es correcto)
                MessageBox.Show("No se puede eliminar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar(true);
        }


        private void Limpiar(bool limpiarId )
        {
            txtIdPartido.Clear();
            txtNombrePartido.Clear();
            txtRutaBandera.Clear();
            picBandera.Image = null;
            _existe = false;
        }


        private void CargarImagen(string ruta)
        {


            try
            {
                if (!string.IsNullOrWhiteSpace(ruta) && File.Exists(ruta))
                {
                    using (var fs = new FileStream(ruta, FileMode.Open, FileAccess.Read))
                    using (var imgTemp = Image.FromStream(fs))
                    {
                        picBandera.Image = (Image)imgTemp.Clone();
                    }
                }
                else
                {
                    picBandera.Image = null;
                }
            }
            catch
            {
                picBandera.Image = null;
            }

        }

        private void dgvPartidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtIdPartido_TextChanged(object sender, EventArgs e)
        {

            if (_cargando) return;

            string txt = txtIdPartido.Text.Trim();
            if (txt == "")
            {
                Limpiar(false);
                return;
            }

            if (!int.TryParse(txt, out int id))
            {
                // Si escriben letras, no buscamos; solo dejamos crear
                _existe = false;
                return;
            }

            try
            {
                string sql = "SELECT IdPartido, NombrePartido, Bandera FROM PartidosPoliticos WHERE IdPartido = @id";
                DataSet ds = Utilidades.ejecutar(sql, new SqlParameter("@id", id));

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    // Existe: cargar datos en txt
                    DataRow r = ds.Tables[0].Rows[0];

                    _cargando = true;

                    txtNombrePartido.Text = r["NombrePartido"]?.ToString();
                    txtRutaBandera.Text = r["Bandera"]?.ToString();
                    CargarImagen(txtRutaBandera.Text);

                    _existe = true;

                    _cargando = false;
                }
                else
                {
                    // No existe: permitir crear (limpiamos datos pero NO borramos el ID)
                    _cargando = true;

                    txtNombrePartido.Clear();
                    txtRutaBandera.Clear();
                    picBandera.Image = null;

                    _existe = false;

                    _cargando = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el partido: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
   "¿Está seguro que desea salir?",
   "Confirmar salida",
   MessageBoxButtons.YesNo,
   MessageBoxIcon.Question
    );
            if (resultado == DialogResult.Yes)
            {
                frmMenuOpciones frm = Application.OpenForms["frmMenuOpciones"] as frmMenuOpciones;
                if (frm != null)
                {
                    frm.Show();
                }
                this.Hide();
                 } 
            }
    }
}
