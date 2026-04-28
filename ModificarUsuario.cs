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
    public partial class ModificarUsuario : Form
    {
        public DataSet ds;
        public string numPerfil;
        public ModificarUsuario()
        {
            InitializeComponent();
        }

        private void cmbPerfil_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("SELECT Perfil FROM Perfiles where DESCPERFIL = '{0}'", cmbPerfil.Text);
                ds = Utilidades.ejecutar(cmd);
                numPerfil = ds.Tables[0].Rows[0]["Perfil"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al consultar la base de datos 003" + ex.Message);

            }
        }

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {
            cmbPerfil.Items.Clear();

            cmbPerfil.Items.Add("Administrador");
            cmbPerfil.Items.Add("Votante");

            cmbPerfil.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbPerfil.SelectedIndex = -1;
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            string cedula = txtNumeroCedula.Text.Trim();

            if (string.IsNullOrEmpty(cedula))
            {
                MessageBox.Show("Ingrese una cédula");
                return;
            }

            if (cmbPerfil.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un rol");
                return;
            }

            string perfil = (cmbPerfil.SelectedIndex == 0) ? "1" : "2";

            string cmd = "UPDATE Usuarios SET Perfil = @perfil WHERE Cedula = @cedula";

            int filas = Utilidades.ejecutarAccion(cmd,
                new SqlParameter("@perfil", perfil),
                new SqlParameter("@cedula", cedula)
            );

            if (filas > 0)
            {
                MessageBox.Show("Rol actualizado correctamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el usuario", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAtrásModificar_Click(object sender, EventArgs e)
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

        private void BuscarUsuario()
        {
            string cedula = txtNumeroCedula.Text.Trim();

            if (string.IsNullOrEmpty(cedula))
            {
                MessageBox.Show("Ingrese una cédula");
                return;
            }

            string consulta = "SELECT Perfil FROM Usuarios WHERE Cedula = @cedula";

            DataSet ds = Utilidades.ejecutar(consulta,
                new SqlParameter("@cedula", cedula));

            if (ds.Tables[0].Rows.Count > 0)
            {
                string perfil = ds.Tables[0].Rows[0]["Perfil"].ToString();

                if (perfil == "1")
                    cmbPerfil.SelectedIndex = 0;
                else if (perfil == "2")
                    cmbPerfil.SelectedIndex = 1;

                MessageBox.Show("Usuario encontrado", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La cédula no está registrada", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                cmbPerfil.SelectedIndex = -1;
            }
        }

        private void txtNumeroCedula_TextChanged(object sender, EventArgs e)
        {
            BuscarUsuario();
        }

        private void btnSalirAlMenu_Click(object sender, EventArgs e)
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
