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
                string cmd = string.Format("SELECT Perfil FROM Perfiles WHERE DESCPERFIL = 'Usuario votante' ", cmbPerfil.Text);
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

        }
    }
}
