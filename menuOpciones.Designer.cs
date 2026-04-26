namespace grupo3_Proyecto
{
    partial class frmMenuOpciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.votaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.votarPresidenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.votarDiputadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.padrónNacionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distritoElectoralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candidatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partidosPolíticosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoElecciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficoProvinciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficoCandidatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeProvinciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeCandidatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créditosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.votaciónToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.estadísticaToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.loginToolStripMenuItem.Text = "Archivo";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // iniciarSesiónToolStripMenuItem
            // 
            this.iniciarSesiónToolStripMenuItem.Name = "iniciarSesiónToolStripMenuItem";
            this.iniciarSesiónToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.iniciarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.iniciarSesiónToolStripMenuItem.Click += new System.EventHandler(this.iniciarSesiónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // votaciónToolStripMenuItem
            // 
            this.votaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.votarPresidenteToolStripMenuItem,
            this.votarDiputadosToolStripMenuItem});
            this.votaciónToolStripMenuItem.Name = "votaciónToolStripMenuItem";
            this.votaciónToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.votaciónToolStripMenuItem.Text = "Votar";
            this.votaciónToolStripMenuItem.Click += new System.EventHandler(this.votaciónToolStripMenuItem_Click);
            // 
            // votarPresidenteToolStripMenuItem
            // 
            this.votarPresidenteToolStripMenuItem.Name = "votarPresidenteToolStripMenuItem";
            this.votarPresidenteToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.votarPresidenteToolStripMenuItem.Text = "Votar Presidente";
            this.votarPresidenteToolStripMenuItem.Click += new System.EventHandler(this.votarPresidenteToolStripMenuItem_Click);
            // 
            // votarDiputadosToolStripMenuItem
            // 
            this.votarDiputadosToolStripMenuItem.Name = "votarDiputadosToolStripMenuItem";
            this.votarDiputadosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.votarDiputadosToolStripMenuItem.Text = "Votar Diputados";
            this.votarDiputadosToolStripMenuItem.Click += new System.EventHandler(this.votarDiputadosToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.padrónNacionalToolStripMenuItem,
            this.distritoElectoralToolStripMenuItem,
            this.candidatosToolStripMenuItem,
            this.partidosPolíticosToolStripMenuItem,
            this.tipoElecciónToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // padrónNacionalToolStripMenuItem
            // 
            this.padrónNacionalToolStripMenuItem.Name = "padrónNacionalToolStripMenuItem";
            this.padrónNacionalToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.padrónNacionalToolStripMenuItem.Text = "Padrón Nacional";
            this.padrónNacionalToolStripMenuItem.Click += new System.EventHandler(this.padrónNacionalToolStripMenuItem_Click);
            // 
            // distritoElectoralToolStripMenuItem
            // 
            this.distritoElectoralToolStripMenuItem.Name = "distritoElectoralToolStripMenuItem";
            this.distritoElectoralToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.distritoElectoralToolStripMenuItem.Text = "Distrito Electoral";
            this.distritoElectoralToolStripMenuItem.Click += new System.EventHandler(this.distritoElectoralToolStripMenuItem_Click);
            // 
            // candidatosToolStripMenuItem
            // 
            this.candidatosToolStripMenuItem.Name = "candidatosToolStripMenuItem";
            this.candidatosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.candidatosToolStripMenuItem.Text = "Registro de Candidatos";
            this.candidatosToolStripMenuItem.Click += new System.EventHandler(this.candidatosToolStripMenuItem_Click);
            // 
            // partidosPolíticosToolStripMenuItem
            // 
            this.partidosPolíticosToolStripMenuItem.Name = "partidosPolíticosToolStripMenuItem";
            this.partidosPolíticosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.partidosPolíticosToolStripMenuItem.Text = "Crear Partidos Políticos";
            this.partidosPolíticosToolStripMenuItem.Click += new System.EventHandler(this.partidosPolíticosToolStripMenuItem_Click);
            // 
            // tipoElecciónToolStripMenuItem
            // 
            this.tipoElecciónToolStripMenuItem.Name = "tipoElecciónToolStripMenuItem";
            this.tipoElecciónToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.tipoElecciónToolStripMenuItem.Text = "Tipo Elección";
            // 
            // estadísticaToolStripMenuItem
            // 
            this.estadísticaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gráficoProvinciaToolStripMenuItem,
            this.gráficoCandidatosToolStripMenuItem});
            this.estadísticaToolStripMenuItem.Name = "estadísticaToolStripMenuItem";
            this.estadísticaToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.estadísticaToolStripMenuItem.Text = "Estadística";
            // 
            // gráficoProvinciaToolStripMenuItem
            // 
            this.gráficoProvinciaToolStripMenuItem.Name = "gráficoProvinciaToolStripMenuItem";
            this.gráficoProvinciaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.gráficoProvinciaToolStripMenuItem.Text = "Gráfico provincia";
            // 
            // gráficoCandidatosToolStripMenuItem
            // 
            this.gráficoCandidatosToolStripMenuItem.Name = "gráficoCandidatosToolStripMenuItem";
            this.gráficoCandidatosToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.gráficoCandidatosToolStripMenuItem.Text = "Gráfico candidatos";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informeProvinciaToolStripMenuItem,
            this.informeCandidatoToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // informeProvinciaToolStripMenuItem
            // 
            this.informeProvinciaToolStripMenuItem.Name = "informeProvinciaToolStripMenuItem";
            this.informeProvinciaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.informeProvinciaToolStripMenuItem.Text = "Informe Provincia";
            // 
            // informeCandidatoToolStripMenuItem
            // 
            this.informeCandidatoToolStripMenuItem.Name = "informeCandidatoToolStripMenuItem";
            this.informeCandidatoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.informeCandidatoToolStripMenuItem.Text = "Informe Candidato";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créditosToolStripMenuItem,
            this.manualDeUsuarioToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // créditosToolStripMenuItem
            // 
            this.créditosToolStripMenuItem.Name = "créditosToolStripMenuItem";
            this.créditosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.créditosToolStripMenuItem.Text = "Créditos";
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            this.manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            this.manualDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.manualDeUsuarioToolStripMenuItem.Text = "Manual de usuario";
            // 
            // frmMenuOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenuOpciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú de opciones";
            this.Load += new System.EventHandler(this.frmMenuOpciones_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem padrónNacionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distritoElectoralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem candidatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partidosPolíticosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem votaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoElecciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadísticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gráficoProvinciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gráficoCandidatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeProvinciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeCandidatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créditosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem votarPresidenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem votarDiputadosToolStripMenuItem;
    }
}