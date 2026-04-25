using MyLibreriaVoto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupo3_Proyecto
{
    public partial class frmDistritoElectoral : Form
    {


        private bool _existe = false;
        private bool _cargando = false;
        private Timer _debounce;


        public frmDistritoElectoral()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar(true);
        }


        private void Limpiar(bool limpiarCodigo)
        {
            _cargando = true;

            if (limpiarCodigo) txtCodigoElectoral.Clear();
            txtProvincia.Clear();
            txtCanton.Clear();
            txtDistrito.Clear();

            txtCodigoElectoral.Enabled = true;
            _existe = false;

            _cargando = false;
        }

        private string NormalizarCodigo(string input)
        {
            if (input == null) return "";
            return input.Replace('\u00A0', ' ')
                        .Replace("\t", "")
                        .Replace("\r", "")
                        .Replace("\n", "")
                        .Trim();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {


            string codigo = Normalizar(txtCodigoElectoral.Text);
            string prov = (txtProvincia.Text ?? "").Trim();
            string canton = (txtCanton.Text ?? "").Trim();
            string distrito = (txtDistrito.Text ?? "").Trim();

            if (string.IsNullOrWhiteSpace(codigo) ||
                string.IsNullOrWhiteSpace(prov) ||
                string.IsNullOrWhiteSpace(canton) ||
                string.IsNullOrWhiteSpace(distrito))
            {
                MessageBox.Show("Debe completar Código Electoral, Provincia, Cantón y Distrito.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_existe)
                {
                    EjecutarUpdate(codigo, prov, canton, distrito);
                    MessageBox.Show("Distrito modificado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // INSERT
                    Utilidades.ejecutarAccion(
                        "INSERT INTO DistritoElectoral (CodigoElectoral, Provincia, Canton, Distrito) " +
                        "VALUES (@c,@p,@ca,@d)",
                        new SqlParameter("@c", codigo),
                        new SqlParameter("@p", prov),
                        new SqlParameter("@ca", canton),
                        new SqlParameter("@d", distrito)
                    );

                    MessageBox.Show("Distrito creado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CargarDistritos();
                Limpiar(true);
            }
            catch (SqlException ex)
            {
                // ✅ Si explotó por PK duplicada, forzamos UPDATE (esto resuelve tu caso)
                if (ex.Message.ToLower().Contains("primary key") || ex.Message.ToLower().Contains("duplicate"))
                {
                    try
                    {
                        EjecutarUpdate(codigo, prov, canton, distrito);
                        MessageBox.Show("Distrito modificado correctamente (se detectó existente).", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CargarDistritos();
                        Limpiar(true);
                        return;
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show("Error SQL:\n" + ex2.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                MessageBox.Show("Error SQL:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnModificar_Click(object sender, EventArgs e)
        {


            string codigo = Normalizar(txtCodigoElectoral.Text);
            if (string.IsNullOrWhiteSpace(codigo))
            {
                MessageBox.Show("Ingrese un Código Electoral para modificar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Para modificar debe existir: si no existe, no tiene sentido un update
            if (!_existe)
            {
                MessageBox.Show("Ese Código Electoral no existe. Use Guardar para crear.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string prov = (txtProvincia.Text ?? "").Trim();
            string canton = (txtCanton.Text ?? "").Trim();
            string distrito = (txtDistrito.Text ?? "").Trim();

            if (string.IsNullOrWhiteSpace(prov) ||
                string.IsNullOrWhiteSpace(canton) ||
                string.IsNullOrWhiteSpace(distrito))
            {
                MessageBox.Show("Debe completar Provincia, Cantón y Distrito.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                EjecutarUpdate(codigo, prov, canton, distrito);

                MessageBox.Show("Distrito modificado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarDistritos();
                Limpiar(true);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error SQL:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AsegurarBotonModificar()
        {
            // Si ya existe en Designer, no hacemos nada
            var existente = this.Controls.Find("btnModificar", true);
            if (existente != null && existente.Length > 0) return;

            // Si no existe, lo creamos debajo de btnGuardar
            Button btn = new Button();
            btn.Name = "btnModificar";
            btn.Text = "Modificar";
            btn.Width = btnGuardar.Width;
            btn.Height = btnGuardar.Height;

            // Ubicación: debajo del botón Guardar
            btn.Left = btnGuardar.Left;
            btn.Top = btnGuardar.Bottom + 8;

            btn.Click += btnModificar_Click;

            this.Controls.Add(btn);
            btn.BringToFront();
        }



        private string Normalizar(string input)
        {
            if (input == null) return "";
            return input.Replace('\u00A0', ' ')
                        .Replace(" ", "")
                        .Trim();
        }


        private void EjecutarUpdate(string codigo, string prov, string canton, string distrito)
        {
            Utilidades.ejecutarAccion(
                "UPDATE DistritoElectoral SET Provincia=@p, Canton=@ca, Distrito=@d WHERE CodigoElectoral=@c",
                new SqlParameter("@p", prov),
                new SqlParameter("@ca", canton),
                new SqlParameter("@d", distrito),
                new SqlParameter("@c", codigo)
            );

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmDistritoElectoral_Load(object sender, EventArgs e)
        {


            ConfigurarGrid();
            CargarDistritos();

            // ✅ Debounce para que al digitar el código no consulte en cada tecla
            _debounce = new Timer();
            _debounce.Interval = 350; // ms
            _debounce.Tick += (s, ev) =>
            {
                _debounce.Stop();
                CargarPorCodigoDigitado();
            };

            // Limpiar inicial
            Limpiar(true);


        }



        private void ConfigurarGrid()
        {

            dgvDistritoElectoral.ReadOnly = true;
            dgvDistritoElectoral.AllowUserToAddRows = false;
            dgvDistritoElectoral.AllowUserToDeleteRows = false;
            dgvDistritoElectoral.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDistritoElectoral.MultiSelect = false;
            dgvDistritoElectoral.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDistritoElectoral.RowHeadersVisible = false;
        }






        private void CargarDistritos()
        {
            DataSet ds = Utilidades.ejecutar(
                "SELECT CodigoElectoral, Provincia, Canton, Distrito FROM DistritoElectoral ORDER BY CodigoElectoral");

            dgvDistritoElectoral.DataSource = ds.Tables[0];
        }

        // =========================
        // AUTOCARGA: al digitar CodigoElectoral
        // =========================
        private void txtCodigoElectoral_TextChanged(object sender, EventArgs e)
        {

            if (_cargando) return;

            // Reinicia el timer (debounce)
            _debounce.Stop();
            _debounce.Start();

        }



        private void CargarPorCodigoDigitado()
        {
            if (_cargando) return;

            string codigo = Normalizar(txtCodigoElectoral.Text);

            if (string.IsNullOrWhiteSpace(codigo))
            {
                Limpiar(false);
                return;
            }

            try
            {
                DataSet ds = Utilidades.ejecutar(
                    "SELECT Provincia, Canton, Distrito FROM DistritoElectoral WHERE CodigoElectoral=@c",
                    new SqlParameter("@c", codigo)
                );

                _cargando = true;

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    DataRow r = ds.Tables[0].Rows[0];

                    txtProvincia.Text = r["Provincia"]?.ToString();
                    txtCanton.Text = r["Canton"]?.ToString();
                    txtDistrito.Text = r["Distrito"]?.ToString();

                    // ✅ Si existe: NO se cambia código electoral
                    txtCodigoElectoral.Enabled = false;
                    _existe = true;
                }
                else
                {
                    // ✅ Si NO existe: permitir crear
                    txtProvincia.Clear();
                    txtCanton.Clear();
                    txtDistrito.Clear();

                    txtCodigoElectoral.Enabled = true;
                    _existe = false;
                }

                _cargando = false;
            }
            catch (Exception ex)
            {
                _cargando = false;
                MessageBox.Show("Error al buscar el distrito: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // =========================
        // Click en el grid -> carga al txt
        // =========================
        private void dgvDistritoElectoral_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex < 0) return;

            _cargando = true;

            DataGridViewRow r = dgvDistritoElectoral.Rows[e.RowIndex];

            txtCodigoElectoral.Text = r.Cells["CodigoElectoral"].Value.ToString();
            txtProvincia.Text = r.Cells["Provincia"].Value?.ToString();
            txtCanton.Text = r.Cells["Canton"].Value?.ToString();
            txtDistrito.Text = r.Cells["Distrito"].Value?.ToString();

            txtCodigoElectoral.Enabled = false;
            _existe = true;

            _cargando = false;

        }

        // =========================
        // GUARDAR (INSERT / UPDATE 100% CORRECTO)
        // =========================
       

    }
}