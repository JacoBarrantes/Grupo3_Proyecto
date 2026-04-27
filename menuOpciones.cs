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


        private void ConfigurarMenuPorPerfil()
        {
            bool esAdmin = Sesion.Perfil == "1";
            bool esVotante = Sesion.Perfil == "2";

            //ADMIN
            mantenimientoToolStripMenuItem.Visible = esAdmin;
            estadísticaToolStripMenuItem.Visible = esAdmin;
            reportesToolStripMenuItem.Visible = esAdmin;

            padrónNacionalToolStripMenuItem.Visible = esAdmin;
            distritoElectoralToolStripMenuItem.Visible = esAdmin;
            candidatosToolStripMenuItem.Visible = esAdmin;
            partidosPolíticosToolStripMenuItem.Visible = esAdmin;
            tipoElecciónToolStripMenuItem.Visible = esAdmin;

  
            votaciónToolStripMenuItem.Visible = false;

            //VOTANTE
            if (esVotante)
            {
                votaciónToolStripMenuItem.Visible = true;
                votarPresidenteToolStripMenuItem.Visible = true;
                votarDiputadosToolStripMenuItem.Visible = true;
            }
            else
            {
                votarPresidenteToolStripMenuItem.Visible = false;
                votarDiputadosToolStripMenuItem.Visible = false;
            }

            //AMBOS
            loginToolStripMenuItem.Visible = true;
            acercaDeToolStripMenuItem.Visible = true;


            modificarUsuarioToolStripMenuItem.Visible = esAdmin; 
        }


        private void AbrirFormulario(Form formulario)
        {
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
            ConfigurarMenuPorPerfil();
        }

        private void padrónNacionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmPadronNacional());


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
            DialogResult r = MessageBox.Show(
                "¿Desea cerrar la sesión actual?",
                "Cerrar sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r != DialogResult.Yes)
                return;

            Sesion.Cerrar();
            this.Close();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                frmLogin frm = Application.OpenForms["frmLogin"] as frmLogin;

                if (frm != null)
                {
                    frm.LimpiarCampos();
                    frm.Show();
                }

                this.Hide();
            }
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

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Sesion.Perfil != "1")
            {
                MessageBox.Show("No tiene permisos para acceder aquí",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AbrirFormulario(new ModificarUsuario());
        }
    }
}
