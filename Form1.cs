using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibreriaVoto;

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
                string contrasena = Utilidades.codificar(txtContrasena.Text.Trim());
                string cmd = string.Format(
                    "SELECT * FROM Usuarios WHERE Cedula = '{0}' AND PasswordHash = '{1}'",
                    cedula, contrasena
                );
                DataSet ds = Utilidades.ejecutar(cmd);
                if (contrasena == txtContrasena.Text.Trim())
                {
                    MessageBox.Show("Bienvenido al sistema de votación");
                    frmMenuOpciones menuOpciones = new frmMenuOpciones();
                    menuOpciones.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Cédula o contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            frmCredenciales credenciales = new frmCredenciales();
            credenciales.ShowDialog();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
