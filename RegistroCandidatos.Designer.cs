namespace grupo3_Proyecto
{
    partial class frmRegistroCandidatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroCandidatos));
            this.btnSalirAlMenu = new System.Windows.Forms.Button();
            this.btnRegistrarCandidato = new System.Windows.Forms.Button();
            this.lblPartidoNuevo = new System.Windows.Forms.Label();
            this.lblCandidatoNuevo = new System.Windows.Forms.Label();
            this.txtIDUsuarioCandidato = new System.Windows.Forms.TextBox();
            this.lblNuevoCandidato = new System.Windows.Forms.Label();
            this.pctContraseña = new System.Windows.Forms.PictureBox();
            this.pctUsuario = new System.Windows.Forms.PictureBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblCandidatura = new System.Windows.Forms.Label();
            this.cmbCandidatura = new System.Windows.Forms.ComboBox();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.cmbPartido = new System.Windows.Forms.ComboBox();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.lblNombreCandidato = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalirAlMenu
            // 
            this.btnSalirAlMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirAlMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirAlMenu.Location = new System.Drawing.Point(432, 396);
            this.btnSalirAlMenu.Name = "btnSalirAlMenu";
            this.btnSalirAlMenu.Size = new System.Drawing.Size(121, 45);
            this.btnSalirAlMenu.TabIndex = 98;
            this.btnSalirAlMenu.Text = "Salir";
            this.btnSalirAlMenu.UseVisualStyleBackColor = true;
            this.btnSalirAlMenu.Click += new System.EventHandler(this.btnSalirAlMenu_Click);
            // 
            // btnRegistrarCandidato
            // 
            this.btnRegistrarCandidato.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRegistrarCandidato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCandidato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCandidato.Location = new System.Drawing.Point(267, 396);
            this.btnRegistrarCandidato.Name = "btnRegistrarCandidato";
            this.btnRegistrarCandidato.Size = new System.Drawing.Size(121, 45);
            this.btnRegistrarCandidato.TabIndex = 97;
            this.btnRegistrarCandidato.Text = "Registrar";
            this.btnRegistrarCandidato.UseVisualStyleBackColor = false;
            this.btnRegistrarCandidato.Click += new System.EventHandler(this.btnRegistrarCandidato_Click);
            // 
            // lblPartidoNuevo
            // 
            this.lblPartidoNuevo.AutoSize = true;
            this.lblPartidoNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartidoNuevo.Location = new System.Drawing.Point(126, 232);
            this.lblPartidoNuevo.Name = "lblPartidoNuevo";
            this.lblPartidoNuevo.Size = new System.Drawing.Size(86, 25);
            this.lblPartidoNuevo.TabIndex = 93;
            this.lblPartidoNuevo.Text = "Partido:";
            // 
            // lblCandidatoNuevo
            // 
            this.lblCandidatoNuevo.AutoSize = true;
            this.lblCandidatoNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandidatoNuevo.Location = new System.Drawing.Point(120, 124);
            this.lblCandidatoNuevo.Name = "lblCandidatoNuevo";
            this.lblCandidatoNuevo.Size = new System.Drawing.Size(161, 25);
            this.lblCandidatoNuevo.TabIndex = 92;
            this.lblCandidatoNuevo.Text = "ID del postulate";
            // 
            // txtIDUsuarioCandidato
            // 
            this.txtIDUsuarioCandidato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDUsuarioCandidato.Location = new System.Drawing.Point(352, 124);
            this.txtIDUsuarioCandidato.Name = "txtIDUsuarioCandidato";
            this.txtIDUsuarioCandidato.Size = new System.Drawing.Size(116, 26);
            this.txtIDUsuarioCandidato.TabIndex = 91;
            this.txtIDUsuarioCandidato.TextChanged += new System.EventHandler(this.txtIDUsuarioCandidato_TextChanged);
            // 
            // lblNuevoCandidato
            // 
            this.lblNuevoCandidato.AutoSize = true;
            this.lblNuevoCandidato.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoCandidato.Location = new System.Drawing.Point(214, 28);
            this.lblNuevoCandidato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNuevoCandidato.Name = "lblNuevoCandidato";
            this.lblNuevoCandidato.Size = new System.Drawing.Size(378, 36);
            this.lblNuevoCandidato.TabIndex = 90;
            this.lblNuevoCandidato.Text = "Ingrese nuevo candidato";
            this.lblNuevoCandidato.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pctContraseña
            // 
            this.pctContraseña.Image = ((System.Drawing.Image)(resources.GetObject("pctContraseña.Image")));
            this.pctContraseña.Location = new System.Drawing.Point(55, 200);
            this.pctContraseña.Name = "pctContraseña";
            this.pctContraseña.Size = new System.Drawing.Size(46, 52);
            this.pctContraseña.TabIndex = 96;
            this.pctContraseña.TabStop = false;
            // 
            // pctUsuario
            // 
            this.pctUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pctUsuario.Image")));
            this.pctUsuario.Location = new System.Drawing.Point(55, 112);
            this.pctUsuario.Name = "pctUsuario";
            this.pctUsuario.Size = new System.Drawing.Size(46, 50);
            this.pctUsuario.TabIndex = 95;
            this.pctUsuario.TabStop = false;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(126, 277);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(113, 25);
            this.lblProvincia.TabIndex = 99;
            this.lblProvincia.Text = "Provincia: ";
            // 
            // lblCandidatura
            // 
            this.lblCandidatura.AutoSize = true;
            this.lblCandidatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandidatura.Location = new System.Drawing.Point(126, 332);
            this.lblCandidatura.Name = "lblCandidatura";
            this.lblCandidatura.Size = new System.Drawing.Size(140, 25);
            this.lblCandidatura.TabIndex = 101;
            this.lblCandidatura.Text = "Candidato a: ";
            // 
            // cmbCandidatura
            // 
            this.cmbCandidatura.FormattingEnabled = true;
            this.cmbCandidatura.Location = new System.Drawing.Point(267, 339);
            this.cmbCandidatura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCandidatura.Name = "cmbCandidatura";
            this.cmbCandidatura.Size = new System.Drawing.Size(202, 21);
            this.cmbCandidatura.TabIndex = 102;
            this.cmbCandidatura.SelectedIndexChanged += new System.EventHandler(this.cmbCandidatura_SelectedIndexChanged);
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Items.AddRange(new object[] {
            "ALAJUELA",
            "SAN JOSE ",
            "CARTAGO",
            "PUNTARENAS",
            "LIMON",
            "GUANACASTE",
            "HEREDIA"});
            this.cmbProvincia.Location = new System.Drawing.Point(267, 283);
            this.cmbProvincia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(202, 21);
            this.cmbProvincia.TabIndex = 103;
            this.cmbProvincia.SelectedIndexChanged += new System.EventHandler(this.cmbProvincia_SelectedIndexChanged);
            // 
            // cmbPartido
            // 
            this.cmbPartido.FormattingEnabled = true;
            this.cmbPartido.Location = new System.Drawing.Point(267, 232);
            this.cmbPartido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbPartido.Name = "cmbPartido";
            this.cmbPartido.Size = new System.Drawing.Size(202, 21);
            this.cmbPartido.TabIndex = 104;
            this.cmbPartido.SelectedIndexChanged += new System.EventHandler(this.cmbPartido_SelectedIndexChanged);
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCompleto.Location = new System.Drawing.Point(352, 188);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(383, 26);
            this.txtNombreCompleto.TabIndex = 105;
            this.txtNombreCompleto.TextChanged += new System.EventHandler(this.txtNombreCompleto_TextChanged);
            // 
            // lblNombreCandidato
            // 
            this.lblNombreCandidato.AutoSize = true;
            this.lblNombreCandidato.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCandidato.Location = new System.Drawing.Point(126, 186);
            this.lblNombreCandidato.Name = "lblNombreCandidato";
            this.lblNombreCandidato.Size = new System.Drawing.Size(222, 25);
            this.lblNombreCandidato.TabIndex = 106;
            this.lblNombreCandidato.Text = "Nombre del candidato";
            // 
            // frmRegistroCandidatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.ControlBox = false;
            this.Controls.Add(this.lblNombreCandidato);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.cmbPartido);
            this.Controls.Add(this.cmbProvincia);
            this.Controls.Add(this.cmbCandidatura);
            this.Controls.Add(this.lblCandidatura);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.btnSalirAlMenu);
            this.Controls.Add(this.btnRegistrarCandidato);
            this.Controls.Add(this.pctContraseña);
            this.Controls.Add(this.pctUsuario);
            this.Controls.Add(this.lblPartidoNuevo);
            this.Controls.Add(this.lblCandidatoNuevo);
            this.Controls.Add(this.txtIDUsuarioCandidato);
            this.Controls.Add(this.lblNuevoCandidato);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistroCandidatos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Registro de Candidatos";
            this.Load += new System.EventHandler(this.frmRegistroCandidatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalirAlMenu;
        private System.Windows.Forms.Button btnRegistrarCandidato;
        private System.Windows.Forms.PictureBox pctContraseña;
        private System.Windows.Forms.PictureBox pctUsuario;
        private System.Windows.Forms.Label lblPartidoNuevo;
        private System.Windows.Forms.Label lblCandidatoNuevo;
        private System.Windows.Forms.TextBox txtIDUsuarioCandidato;
        private System.Windows.Forms.Label lblNuevoCandidato;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblCandidatura;
        private System.Windows.Forms.ComboBox cmbCandidatura;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.ComboBox cmbPartido;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label lblNombreCandidato;
    }
}