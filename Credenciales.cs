using MyLibreriaVoto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupo3_Proyecto
{
    public partial class frmCredenciales : Form
    {
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string contrasena;
                contrasena = Utilidades.codificar(txtPassword1.Text.Trim());
                int perfil = 2; 

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


                
                string cmd = string.Format(
                    "INSERT INTO Usuarios (Cedula, PasswordHash, CorreoElectronico, Perfil) " +
                    "VALUES ('{0}', '{1}', '{2}', {3})",
                    txtId.Text.Trim(), contrasena, txtCorreo.Text.Trim(), perfil
                );
                Utilidades.ejecutarAccion(cmd);

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
        }

        private void frmCredenciales_Load(object sender, EventArgs e)
        {

        }
    }
}
