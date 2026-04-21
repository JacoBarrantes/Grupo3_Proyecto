using MyLibreriaVoto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupo3_Proyecto
{
    

    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCedula_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
               
            IniciarSesion();          


        }


        private void IniciarSesion()
        {
            try
            {
                string cedula = txtCedula.Text.Trim();
                string contrasenaHash = Utilidades.codificar(txtContrasena.Text.Trim());

                if (string.IsNullOrWhiteSpace(cedula) || string.IsNullOrWhiteSpace(txtContrasena.Text))
                {
                    MessageBox.Show("Debe ingresar cédula y contraseña", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string cmd = "SELECT Cedula, Perfil FROM Usuarios WHERE Cedula = @cedula AND PasswordHash = @hash";
                DataSet ds = Utilidades.ejecutar(cmd,
                    new SqlParameter("@cedula", cedula),
                    new SqlParameter("@hash", contrasenaHash)
                );

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    // ✅ Guardar datos de sesión
                    Sesion.Cedula = cedula;
                    Sesion.Rol = Convert.ToInt32(ds.Tables[0].Rows[0]["Perfil"]);

                    MessageBox.Show("Bienvenido al sistema de votación", "Bienvenido",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // ✅ Ocultar login
                    this.Hide();

                    // ✅ Abrir menú principal
                    frmMenuOpciones menuOpciones = new frmMenuOpciones();

                    // ✅ Cuando el menú se cierre, volver a mostrar el login
                    menuOpciones.FormClosed += (s, e) =>
                    {
                        this.Show();
                    };

                    menuOpciones.Show();
                }
                else
                {
                    MessageBox.Show("Cédula o contraseña incorrecta", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        private void btnSalir_Click(object sender, EventArgs e)
        {
          

            Application.Exit();

        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            // 1) Ocultas el login
            this.Hide();

            // 2) Abres el formulario de registro
            frmCredenciales credenciales = new frmCredenciales();

            // 3) Cuando cierre el registro, vuelve a mostrar el login
            credenciales.FormClosed += (s, args) =>
            {
                this.Show();
            };

            credenciales.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
