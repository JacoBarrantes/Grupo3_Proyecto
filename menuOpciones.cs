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
    public partial class frmMenuOpciones : Form
    {
        public frmMenuOpciones()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void candidatosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMenuOpciones_Load(object sender, EventArgs e)
        {

        }

        private void padrónNacionalToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }

        private void presidenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarUsuario frmModificarUsuario = new ModificarUsuario();
            frmModificarUsuario.ShowDialog();
        }

        private void diputacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarUsuario frmEliminarUsuario = new EliminarUsuario();
            frmEliminarUsuario.ShowDialog();
        }
    }
}
