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
                .Select(r => r["Provincia"].ToString().Trim())
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            cmbProvincia.DataSource = provincias;

            cmbCanton.DataSource = null;
            cmbDistrito.DataSource = null;

            _cargando = false;

        }




        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cargando) return;

            _cargando = true;

            string prov = cmbProvincia.Text;

            var cantones = _dtDistritos.AsEnumerable()
                .Where(r => r["Provincia"].ToString() == prov)
                .Select(r => r["Canton"].ToString())
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            cmbCanton.DataSource = cantones;
            cmbDistrito.DataSource = null;

            _cargando = false;
        }


        private void cmbCanton_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cargando) return;

            _cargando = true;

            string prov = cmbProvincia.Text;
            string canton = cmbCanton.Text;

            var distritos = _dtDistritos.AsEnumerable()
                .Where(r => r["Provincia"].ToString() == prov && r["Canton"].ToString() == canton)
                .Select(r => r["Distrito"].ToString())
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            cmbDistrito.DataSource = distritos;

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


        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtCorreo.Text.Trim() == "" || txtId.Text.Trim() == "" || txtPassword1.Text.Trim() == "" || txtPassword2.Text.Trim() == "")
                {
                    MessageBox.Show("Debe llenar todos los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtPassword1.Text != txtPassword2.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }                

                string contrasena = Utilidades.codificar(txtPassword1.Text.Trim()); 
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
            txtPassword1.Clear();
            txtPassword2.Clear();
            if (cmbProvincia.Items.Count > 0) cmbProvincia.SelectedIndex = 0;
        }



        private void cmbDistrito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Cerrar la ventana acutal y volver al login
            this.Close();
        }
    }
}
