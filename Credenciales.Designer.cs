namespace grupo3_Proyecto
{
    partial class frmCredenciales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCredenciales));
            this.lblCredenciales = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseñaNueva = new System.Windows.Forms.Label();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pctContraseña = new System.Windows.Forms.PictureBox();
            this.pctUsuario = new System.Windows.Forms.PictureBox();
            this.lblDistrito = new System.Windows.Forms.Label();
            this.lblCanton = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.cmbCanton = new System.Windows.Forms.ComboBox();
            this.cmbDistrito = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCredenciales
            // 
            this.lblCredenciales.AutoSize = true;
            this.lblCredenciales.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredenciales.Location = new System.Drawing.Point(237, 33);
            this.lblCredenciales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCredenciales.Name = "lblCredenciales";
            this.lblCredenciales.Size = new System.Drawing.Size(428, 36);
            this.lblCredenciales.TabIndex = 81;
            this.lblCredenciales.Text = "Registro de nuevos usuarios";
            this.lblCredenciales.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCredenciales.Click += new System.EventHandler(this.lblCredenciales_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(357, 138);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(194, 26);
            this.txtId.TabIndex = 82;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(108, 137);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(138, 25);
            this.lblUsuario.TabIndex = 83;
            this.lblUsuario.Text = "Ingrese su ID";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuarioNuevo_Click);
            // 
            // lblContraseñaNueva
            // 
            this.lblContraseñaNueva.AutoSize = true;
            this.lblContraseñaNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaNueva.Location = new System.Drawing.Point(108, 199);
            this.lblContraseñaNueva.Name = "lblContraseñaNueva";
            this.lblContraseñaNueva.Size = new System.Drawing.Size(225, 25);
            this.lblContraseñaNueva.TabIndex = 84;
            this.lblContraseñaNueva.Text = "Ingrese su contraseña";
            // 
            // txtPassword1
            // 
            this.txtPassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword1.Location = new System.Drawing.Point(357, 200);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Size = new System.Drawing.Size(194, 26);
            this.txtPassword1.TabIndex = 85;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(227, 395);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(121, 45);
            this.btnRegistrar.TabIndex = 88;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(564, 395);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 45);
            this.btnSalir.TabIndex = 89;
            this.btnSalir.Text = "Volver";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtPassword2
            // 
            this.txtPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword2.Location = new System.Drawing.Point(357, 265);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(194, 26);
            this.txtPassword2.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 90;
            this.label1.Text = "Confirme su contraseña";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(108, 331);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(179, 25);
            this.lblCorreo.TabIndex = 94;
            this.lblCorreo.Text = "Ingrese su correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(357, 332);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(194, 26);
            this.txtCorreo.TabIndex = 93;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(392, 395);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(121, 45);
            this.btnLimpiar.TabIndex = 96;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(43, 318);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 50);
            this.pictureBox2.TabIndex = 95;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 249);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 50);
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // pctContraseña
            // 
            this.pctContraseña.Image = ((System.Drawing.Image)(resources.GetObject("pctContraseña.Image")));
            this.pctContraseña.Location = new System.Drawing.Point(43, 184);
            this.pctContraseña.Name = "pctContraseña";
            this.pctContraseña.Size = new System.Drawing.Size(46, 50);
            this.pctContraseña.TabIndex = 87;
            this.pctContraseña.TabStop = false;
            // 
            // pctUsuario
            // 
            this.pctUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pctUsuario.Image")));
            this.pctUsuario.Location = new System.Drawing.Point(43, 113);
            this.pctUsuario.Name = "pctUsuario";
            this.pctUsuario.Size = new System.Drawing.Size(46, 50);
            this.pctUsuario.TabIndex = 86;
            this.pctUsuario.TabStop = false;
            this.pctUsuario.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblDistrito
            // 
            this.lblDistrito.AutoSize = true;
            this.lblDistrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrito.Location = new System.Drawing.Point(584, 265);
            this.lblDistrito.Name = "lblDistrito";
            this.lblDistrito.Size = new System.Drawing.Size(79, 25);
            this.lblDistrito.TabIndex = 101;
            this.lblDistrito.Text = "Distrito";
            // 
            // lblCanton
            // 
            this.lblCanton.AutoSize = true;
            this.lblCanton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanton.Location = new System.Drawing.Point(584, 199);
            this.lblCanton.Name = "lblCanton";
            this.lblCanton.Size = new System.Drawing.Size(81, 25);
            this.lblCanton.TabIndex = 99;
            this.lblCanton.Text = "Canton";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(584, 137);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(101, 25);
            this.lblProvincia.TabIndex = 98;
            this.lblProvincia.Text = "Provincia";
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Items.AddRange(new object[] {
            "ALAJUELA",
            "HEREDIA",
            "SAN JOSE",
            "CARTAGO",
            "PUNTARENAS",
            "GUANACASTE",
            "LIMON"});
            this.cmbProvincia.Location = new System.Drawing.Point(690, 146);
            this.cmbProvincia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(112, 21);
            this.cmbProvincia.TabIndex = 103;
            this.cmbProvincia.SelectedIndexChanged += new System.EventHandler(this.cmbProvincia_SelectedIndexChanged);
            // 
            // cmbCanton
            // 
            this.cmbCanton.FormattingEnabled = true;
            this.cmbCanton.Items.AddRange(new object[] {
            "CURRIDABAT ",
            "PEREZ ZELEDON",
            "LIBERIA NICOYA",
            "GRECIA",
            "SAN MATEO",
            "ATENAS",
            "QUEPOS ",
            "OSA",
            "GOLFITO",
            "PARRITA"});
            this.cmbCanton.Location = new System.Drawing.Point(690, 205);
            this.cmbCanton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCanton.Name = "cmbCanton";
            this.cmbCanton.Size = new System.Drawing.Size(112, 21);
            this.cmbCanton.TabIndex = 104;
            this.cmbCanton.SelectedIndexChanged += new System.EventHandler(this.cmbCanton_SelectedIndexChanged);
            // 
            // cmbDistrito
            // 
            this.cmbDistrito.FormattingEnabled = true;
            this.cmbDistrito.Items.AddRange(new object[] {
            "PILAS",
            "PALMAR",
            "SANTA CRUZ",
            "SAN JUAN",
            "SAN MATEO",
            "TRES RIOS",
            "OROSI",
            "SANTIAGO",
            "EL ROSARIO",
            "SAN PEDRO"});
            this.cmbDistrito.Location = new System.Drawing.Point(690, 271);
            this.cmbDistrito.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDistrito.Name = "cmbDistrito";
            this.cmbDistrito.Size = new System.Drawing.Size(112, 21);
            this.cmbDistrito.TabIndex = 105;
            this.cmbDistrito.SelectedIndexChanged += new System.EventHandler(this.cmbDistrito_SelectedIndexChanged);
            // 
            // frmCredenciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(875, 486);
            this.Controls.Add(this.cmbDistrito);
            this.Controls.Add(this.cmbCanton);
            this.Controls.Add(this.cmbProvincia);
            this.Controls.Add(this.lblDistrito);
            this.Controls.Add(this.lblCanton);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.pctContraseña);
            this.Controls.Add(this.pctUsuario);
            this.Controls.Add(this.txtPassword1);
            this.Controls.Add(this.lblContraseñaNueva);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblCredenciales);
            this.Name = "frmCredenciales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credenciales";
            this.Load += new System.EventHandler(this.frmCredenciales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCredenciales;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseñaNueva;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.PictureBox pctUsuario;
        private System.Windows.Forms.PictureBox pctContraseña;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblDistrito;
        private System.Windows.Forms.Label lblCanton;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.ComboBox cmbCanton;
        private System.Windows.Forms.ComboBox cmbDistrito;
    }
}