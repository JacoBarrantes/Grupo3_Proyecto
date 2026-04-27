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
    public partial class frmCredenciales : Form
    {


        private DataTable _dtDistritos;
        private bool _cargando = false;

        public frmCredenciales()
        {
            InitializeComponent();
        }

        private void lblUsuarioNuevo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblCredenciales_Click(object sender, EventArgs e)
        {

        }



        private void frmCredenciales_Load(object sender, EventArgs e)
        {
            CargarDistritos();
            CargarProvincias();
                   
            cmbProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCanton.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDistrito.DropDownStyle = ComboBoxStyle.DropDownList;


        }


        private void CargarDistritos()
        {
            DataSet ds = Utilidades.ejecutar("SELECT CodigoElectoral, Provincia, Canton, Distrito FROM DistritoElectoral");
            _dtDistritos = ds.Tables[0];
        }


        private void CargarProvincias()
        {

            _cargando = true;

            var provincias = _dtDistritos.AsEnumerable()
                .Select(r => r["Provincia"].ToString().Trim().ToUpper()) 
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            cmbProvincia.DataSource = provincias;

            cmbCanton.DataSource = null;
            cmbDistrito.DataSource = null;

            cmbProvincia.SelectedIndex = -1;
            cmbProvincia.Text = "";

            _cargando = false;

        }




        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cargando) return;
            if (string.IsNullOrEmpty(cmbProvincia.Text)) return;

            _cargando = true;

            string prov = cmbProvincia.Text;

            var cantones = _dtDistritos.AsEnumerable()
                .Where(r => string.Equals(r["Provincia"].ToString(), prov, StringComparison.OrdinalIgnoreCase))
                .Select(r => r["Canton"].ToString().ToUpper())
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            cmbCanton.DataSource = cantones;

            cmbCanton.SelectedIndex = -1;
            cmbDistrito.DataSource = null;

            _cargando = false;
        }


        private void cmbCanton_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cargando) return;
            if (string.IsNullOrEmpty(cmbCanton.Text)) return;

            _cargando = true;

            string prov = cmbProvincia.Text;
            string canton = cmbCanton.Text;

            var distritos = _dtDistritos.AsEnumerable()
                .Where(r =>
                    string.Equals(r["Provincia"].ToString(), prov, StringComparison.OrdinalIgnoreCase) &&
                    string.Equals(r["Canton"].ToString(), canton, StringComparison.OrdinalIgnoreCase))
                .Select(r => r["Distrito"].ToString().ToUpper()) 
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            cmbDistrito.DataSource = distritos;

            cmbDistrito.SelectedIndex = -1;

            _cargando = false;
        }



        private string ObtenerCodigoElectoralSeleccionado()
        {
            string prov = cmbProvincia.Text;
            string canton = cmbCanton.Text;
            string distrito = cmbDistrito.Text;

            var match = _dtDistritos.AsEnumerable()
                .FirstOrDefault(r =>
                    r["Provincia"].ToString() == prov &&
                    r["Canton"].ToString() == canton &&
                    r["Distrito"].ToString() == distrito);

            return match?["CodigoElectoral"]?.ToString();
        }

        private bool ValidarContrasena(string pass)
        {
            if (pass.Length < 8 || pass.Length > 15)
                return false;

            bool tieneNumero = pass.Any(char.IsDigit);
            bool tieneMayus = pass.Any(char.IsUpper);
            bool tieneMinus = pass.Any(char.IsLower);

            return tieneNumero && tieneMayus && tieneMinus;
        }

        private bool ValidarCorreo(string correo)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(
                correo,
                @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
            );
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!ValidarContrasena(txtContrasena.Text))
            {
                MessageBox.Show("La contraseña debe tener entre 8 y 15 caracteres, incluir mayúsculas, minúsculas y números",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCorreo(txtCorreo.Text))
            {
                MessageBox.Show("Ingrese un correo electrónico válido",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CedulaExiste(txtId.Text.Trim()))
            {
                MessageBox.Show("La cédula ya está registrada en el sistema",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (txtCorreo.Text.Trim() == "" || txtId.Text.Trim() == "" || txtContrasena.Text.Trim() == "" || txtConfirmarContrasena.Text.Trim() == "")
                {
                    MessageBox.Show("Debe llenar todos los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtContrasena.Text != txtConfirmarContrasena.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }                

                string contrasena = Utilidades.codificar(txtContrasena.Text.Trim()); 
                string perfil = "2";

                string cmd =
                    "INSERT INTO Usuarios (Cedula, PasswordHash, CorreoElectronico, Perfil, Provincia, Canton, Distrito) " +
                    "VALUES (@cedula, @hash, @correo, @perfil, @provincia, @canton, @distrito)";

                Utilidades.ejecutarAccion(cmd,
                    new SqlParameter("@cedula", txtId.Text.Trim()),
                    new SqlParameter("@hash", contrasena),
                    new SqlParameter("@correo", txtCorreo.Text.Trim()),
                    new SqlParameter("@perfil", perfil),
                    new SqlParameter("@provincia", cmbProvincia.Text),
                    new SqlParameter("@canton", cmbCanton.Text),
                    new SqlParameter("@distrito", cmbDistrito.Text)
                );

                MessageBox.Show("Usuario registrado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLimpiar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }





        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            txtCorreo.Clear();
            txtId.Clear();
            txtContrasena.Clear();
            txtConfirmarContrasena.Clear();

            txtNombre.Clear();
            textApellido1.Clear();
            txtApellido2.Clear();

      
            dtpVencimiento.Value = DateTime.Now;

       
            if (cmbProvincia.Items.Count > 0)
                cmbProvincia.SelectedIndex = 0;

            cmbCanton.DataSource = null;
            cmbDistrito.DataSource = null;

           
            btnRegistrar.Enabled = false;
        }



        private void cmbDistrito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Cerrar la ventana acutal y volver al login
            this.Close();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            ConsultarCedula();
        }
        private void ConsultarCedula()
        {
            string cedula = txtId.Text.Trim();

            if (string.IsNullOrEmpty(cedula))
                return;

            string consulta = "SELECT Nombre, PrimerApellido, SegundoApellido, FechaVencimientoCedula " +
                              "FROM PadronNacional WHERE Cedula = @cedula";

            DataSet ds = Utilidades.ejecutar(consulta,
                new SqlParameter("@cedula", cedula));

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtNombre.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
                textApellido1.Text = ds.Tables[0].Rows[0]["PrimerApellido"].ToString();
                txtApellido2.Text = ds.Tables[0].Rows[0]["SegundoApellido"].ToString();

                string fechaTexto = ds.Tables[0].Rows[0]["FechaVencimientoCedula"].ToString();

                if (fechaTexto.Length == 8)
                {
                    int anio = int.Parse(fechaTexto.Substring(0, 4));
                    int mes = int.Parse(fechaTexto.Substring(4, 2));
                    int dia = int.Parse(fechaTexto.Substring(6, 2));

                    dtpVencimiento.Value = new DateTime(anio, mes, dia);

                    if (dtpVencimiento.Value.Date < DateTime.Now.Date)
                    {
                        MessageBox.Show("La cédula está vencida", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        btnRegistrar.Enabled = false;
                    }
                    else
                    {
                        btnRegistrar.Enabled = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Cédula no encontrada", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNombre.Clear();
                textApellido1.Clear();
                txtApellido2.Clear();
            }
        }

   

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private bool CedulaExiste(string cedula)
        {
            string consulta = "SELECT COUNT(*) FROM Usuarios WHERE Cedula = @cedula";

            DataSet ds = Utilidades.ejecutar(consulta,
                new SqlParameter("@cedula", cedula));

            int cantidad = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            return cantidad > 0;
        }
    }
}
