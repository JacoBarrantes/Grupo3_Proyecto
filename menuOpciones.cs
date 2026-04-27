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
            this.IsMdiContainer = true;
        }




        // Método central para abrir formularios dentro del menú
        private void AbrirFormulario(Form formulario)
        {
            // Cierra formularios hijos existentes
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }

            formulario.MdiParent = this;
            formulario.WindowState = FormWindowState.Maximized;
            formulario.Show();
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
            AbrirFormulario(new frmRegistroCandidatos());
        }

        private void frmMenuOpciones_Load(object sender, EventArgs e)
        {

        }

        private void padrónNacionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmPadronNacional());


        }

        private void presidenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new ModificarUsuario());
        }

        private void diputacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new EliminarUsuario());
        }

        private void votaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void votarPresidenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // 1 = Presidencial
            AbrirFormulario(new frmVotacion(Sesion.Cedula, 1));

        }

        private void votarDiputadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // 2 = Diputados
            AbrirFormulario(new frmVotacion(Sesion.Cedula, 2));

        }

        private void iniciarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Confirmación opcional
            DialogResult r = MessageBox.Show(
                "¿Desea cerrar la sesión actual?",
                "Cerrar sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r != DialogResult.Yes)
                return;

            // 1️⃣ Limpiar la sesión
            Sesion.Cerrar();         
           

         
            this.Close();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = Application.OpenForms["frmLogin"] as frmLogin;

            if (frm != null)
            {
                frm.Show();
            }

            this.Hide(); 
        }

        private void partidosPolíticosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmPartidosPoliticos());
        }

        private void distritoElectoralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmDistritoElectoral());
        }

        private void informeProvinciaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
