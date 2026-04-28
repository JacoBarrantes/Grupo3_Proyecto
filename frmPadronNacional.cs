using MyLibreriaVoto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupo3_Proyecto
{
    public partial class frmPadronNacional : Form
    {
        private bool existePersona = false;
        private bool _cargandoAuto = false;
        public frmPadronNacional()
        {
            InitializeComponent();
        }

        private void frmPadronNacional_Load(object sender, EventArgs e)
        {


            CargarPadron();


            dgvPadron.ReadOnly = true;
            dgvPadron.AllowUserToAddRows = false;
            dgvPadron.AllowUserToDeleteRows = false;
            dgvPadron.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPadron.MultiSelect = false;



        }


        private void CargarPadron()
        {

            DataSet ds = Utilidades.ejecutar(
                            "SELECT Cedula, CodigoElectoral, FechaVencimientoCedula, NumeroJuntaReceptora, " +
                            "Nombre, PrimerApellido, SegundoApellido " +
                            "FROM PadronNacional");

            dgvPadron.DataSource = ds.Tables[0];


        }




        private bool TryParseFecha(object valor, out DateTime fecha)
        {
            fecha = DateTime.Today;

            if (valor == null || valor == DBNull.Value) return false;

            // Si ya viene como DateTime en el DataSet
            if (valor is DateTime dt)
            {
                fecha = dt;
                return true;
            }

            string s = valor.ToString().Trim();
            if (string.IsNullOrWhiteSpace(s)) return false;

            // Intentos de formato comunes
            string[] formatos = { "yyyyMMdd", "ddMMyyyy", "yyyy-MM-dd", "dd/MM/yyyy", "MM/dd/yyyy" };

            if (DateTime.TryParseExact(s, formatos, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime exacta))
            {
                fecha = exacta;
                return true;
            }

            // Último intento con cultura del sistema
            if (DateTime.TryParse(s, out DateTime normal))
            {
                fecha = normal;
                return true;
            }
            return false;
        }



        private void dgvPadron_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            DataGridViewRow r = dgvPadron.Rows[e.RowIndex];

            _cargandoAuto = true;

            txtCedula.Text = r.Cells["Cedula"].Value.ToString();
            txtCodigoElectoral.Text = r.Cells["CodigoElectoral"].Value.ToString();
            txtJunta.Text = r.Cells["NumeroJuntaReceptora"].Value.ToString();
            txtNombre.Text = r.Cells["Nombre"].Value.ToString();
            txtApellido1.Text = r.Cells["PrimerApellido"].Value.ToString();
            txtApellido2.Text = r.Cells["SegundoApellido"].Value.ToString();

            // ✅ Parse seguro desde el grid también
            if (TryParseFecha(r.Cells["FechaVencimientoCedula"].Value, out DateTime venc))
                dtpVencimiento.Value = venc;
            else
                dtpVencimiento.Value = DateTime.Today;

            txtCedula.Enabled = false;
            existePersona = true;

            _cargandoAuto = false;

        }




        private DateTime ParseFechaSeguro(object valor)
        {
            if (valor == null || valor == DBNull.Value) return DateTime.Today;

            if (valor is DateTime dt) return dt;

            string s = valor.ToString().Trim();
            if (string.IsNullOrWhiteSpace(s)) return DateTime.Today;

            string[] formatos = { "yyyyMMdd", "ddMMyyyy", "yyyy-MM-dd", "dd/MM/yyyy", "MM/dd/yyyy" };
            if (DateTime.TryParseExact(s, formatos, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime exacta))
                return exacta;

            if (DateTime.TryParse(s, out DateTime normal))
                return normal;

            return DateTime.Today;
        }



        private string ObtenerCodigoElectoralCanonico(string codigoDigitado)
        {
            if (string.IsNullOrWhiteSpace(codigoDigitado)) return null;

            // Normaliza input (quita NBSP, espacios, guiones)
            string cod = codigoDigitado.Replace('\u00A0', ' ')
                                       .Replace(" ", "")
                                       .Replace("-", "")
                                       .Trim();

            object result = Utilidades.ejecutarEscalar(
                "SELECT TOP 1 CodigoElectoral " +
                "FROM DistritoElectoral " +
                "WHERE " +
                "  REPLACE(REPLACE(LTRIM(RTRIM(CodigoElectoral)), CHAR(160), ''), ' ', '') = @cod " +
                "  OR TRY_CONVERT(INT, CodigoElectoral) = TRY_CONVERT(INT, @cod)",
                new SqlParameter("@cod", cod)
            );

            if (result == null || result == DBNull.Value) return null;

            return result.ToString();
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string cedula = (txtCedula.Text ?? "").Trim();
            if (string.IsNullOrWhiteSpace(cedula))
            {
                MessageBox.Show("Debe ingresar una cédula.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1) Buscar el CódigoElectoral canónico REAL en DistritoElectoral
            string codigoDigitado = (txtCodigoElectoral.Text ?? "").Trim();
            string codigoCanonico = ObtenerCodigoElectoralCanonico(codigoDigitado);

            if (string.IsNullOrWhiteSpace(codigoCanonico))
            {
                MessageBox.Show(
                    "El Código Electoral ingresado NO existe en DistritoElectoral.\n" +
                    "Ingrese uno válido (o selecciónelo desde los combos).",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (existePersona)
                {
                    // UPDATE
                    string sqlUpdate =
                        "UPDATE PadronNacional SET " +
                        "CodigoElectoral=@ce, " +
                        "FechaVencimientoCedula=@f, " +
                        "NumeroJuntaReceptora=@j, " +
                        "Nombre=@n, " +
                        "PrimerApellido=@a1, " +
                        "SegundoApellido=@a2 " +
                        "WHERE Cedula=@c";

                    Utilidades.ejecutarAccion(sqlUpdate,
                        new SqlParameter("@c", cedula),
                        new SqlParameter("@ce", codigoCanonico), // ✅ guardamos el canónico
                        new SqlParameter("@f", dtpVencimiento.Value),
                        new SqlParameter("@j", (txtJunta.Text ?? "").Trim()),
                        new SqlParameter("@n", (txtNombre.Text ?? "").Trim()),
                        new SqlParameter("@a1", (txtApellido1.Text ?? "").Trim()),
                        new SqlParameter("@a2", (txtApellido2.Text ?? "").Trim())
                    );

                    MessageBox.Show("Persona modificada correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // INSERT
                    string sqlInsert =
                        "INSERT INTO PadronNacional " +
                        "(Cedula, CodigoElectoral, FechaVencimientoCedula, NumeroJuntaReceptora, " +
                        "Nombre, PrimerApellido, SegundoApellido) " +
                        "VALUES (@c, @ce, @f, @j, @n, @a1, @a2)";

                    Utilidades.ejecutarAccion(sqlInsert,
                        new SqlParameter("@c", cedula),
                        new SqlParameter("@ce", codigoCanonico), // ✅ guardamos el canónico
                        new SqlParameter("@f", dtpVencimiento.Value),
                        new SqlParameter("@j", (txtJunta.Text ?? "").Trim()),
                        new SqlParameter("@n", (txtNombre.Text ?? "").Trim()),
                        new SqlParameter("@a1", (txtApellido1.Text ?? "").Trim()),
                        new SqlParameter("@a2", (txtApellido2.Text ?? "").Trim())
                    );

                    MessageBox.Show("Persona creada correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CargarPadron();
                LimpiarCampos(true);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error SQL:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Así eliminamos duplicación: Modificar = Guardar cuando existe
            if (!existePersona)
            {
                MessageBox.Show("No existe esa cédula en el padrón. Use Guardar para crear.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            btnGuardar_Click(sender, e);



        }


        // ✅ Función local de normalización (pégala dentro de la clase frmPadronNacional)
        private string NormalizarCodigoElectoral(string input)
        {
            if (input == null) return "";

            // NBSP (U+00A0) -> espacio normal, luego Trim
            string s = input.Replace('\u00A0', ' ')
                            .Replace("\t", "")
                            .Replace("\r", "")
                            .Replace("\n", "")
                            .Trim();

            // opcional: quitar guiones o espacios internos
            s = s.Replace("-", "").Replace(" ", "");

            return s;
        }




        private void btnNuevo_Click(object sender, EventArgs e)
        {

            LimpiarCampos(true);
           


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {


            string ced = (txtCedula.Text ?? "").Trim();

            if (string.IsNullOrWhiteSpace(ced))
            {
                MessageBox.Show("Ingrese una cédula para eliminar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Eliminar esta persona del padrón?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                string sql = "DELETE FROM PadronNacional WHERE Cedula=@c";
                int filas = Utilidades.ejecutarAccion(sql, new SqlParameter("@c", ced));

                if (filas > 0)
                    MessageBox.Show("Persona eliminada correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se encontró esa cédula en el padrón.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                CargarPadron();
                LimpiarCampos(true);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se puede eliminar (relaciones/constraints):\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }


        private void LimpiarCampos(bool limpiarCedula)
        {

            _cargandoAuto = true;

            if (limpiarCedula)
                txtCedula.Clear();

            txtCodigoElectoral.Clear();
            txtJunta.Clear();
            txtNombre.Clear();
            txtApellido1.Clear();
            txtApellido2.Clear();

            dtpVencimiento.Value = DateTime.Today;

            txtCedula.Enabled = true;
            existePersona = false;

            _cargandoAuto = false;


        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

            if (_cargandoAuto) return;

            string ced = txtCedula.Text.Trim();

            // Para no consultar en cada tecla, espera mínimo 6 caracteres
            if (ced.Length < 6)
                return;

            try
            {
                string sql = "SELECT Cedula, CodigoElectoral, FechaVencimientoCedula, NumeroJuntaReceptora, " +
                             "Nombre, PrimerApellido, SegundoApellido " +
                             "FROM PadronNacional WHERE Cedula = @c";

                DataSet ds = Utilidades.ejecutar(sql, new SqlParameter("@c", ced));

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    DataRow r = ds.Tables[0].Rows[0];

                    _cargandoAuto = true;

                    txtCodigoElectoral.Text = r["CodigoElectoral"]?.ToString();
                    txtJunta.Text = r["NumeroJuntaReceptora"]?.ToString();
                    txtNombre.Text = r["Nombre"]?.ToString();
                    txtApellido1.Text = r["PrimerApellido"]?.ToString();
                    txtApellido2.Text = r["SegundoApellido"]?.ToString();


                    // ✅ AQUÍ ESTÁ LA CORRECCIÓN DEL ERROR
                    if (TryParseFecha(r["FechaVencimientoCedula"], out DateTime venc))
                        dtpVencimiento.Value = venc;
                    else
                        dtpVencimiento.Value = DateTime.Today; // fallback

                    txtCedula.Enabled = false;
                    existePersona = true;

                    _cargandoAuto = false;
                }
                else
                {
                    // No existe: permitir crear
                    existePersona = false;
                    LimpiarCampos(false); // no borra cédula
                }
            }
            catch (Exception ex)
            {
                // En vez de romper todo, mostramos un mensaje claro
                MessageBox.Show("Error al cargar por cédula: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void txtCodigoElectoral_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpVencimientoCedula_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtJunta_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvPadron_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
