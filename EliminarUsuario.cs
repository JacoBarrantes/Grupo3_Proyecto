using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibreriaVoto;

namespace grupo3_Proyecto
{
    public partial class EliminarUsuario : Form
    {
        public EliminarUsuario()
        {
            InitializeComponent();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtUsuarioEliminado.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar la cédula", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               
                DialogResult resp = MessageBox.Show(
                    "¿Está seguro de eliminar este usuario?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resp == DialogResult.No)
                    return;

                
                string cmd = string.Format(
                    "DELETE FROM PadronNacional WHERE Cedula = '{0}'",
                    txtUsuarioEliminado.Text.Trim()
                );

                // 🚀 Ejecutar
                int resultado = Utilidades.ejecutarAccion(cmd);

                // ✅ Resultado
                if (resultado > 0)
                {
                    MessageBox.Show("Usuario eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsuarioEliminado.Clear();
                    txtUsuarioEliminado.Focus();
                }
                else
                {
                    MessageBox.Show("No se encontró la cédula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void EliminarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}