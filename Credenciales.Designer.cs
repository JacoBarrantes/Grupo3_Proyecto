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
            this.lblCredenciales = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblContraseñaNueva = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtConfirmarContrasena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblDistrito = new System.Windows.Forms.Label();
            this.lblCanton = new System.Windows.Forms.Label();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.cmbCanton = new System.Windows.Forms.ComboBox();
            this.cmbDistrito = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.textApellido1 = new System.Windows.Forms.TextBox();
            this.lblApellido2 = new System.Windows.Forms.Label();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
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
            this.txtId.Location = new System.Drawing.Point(151, 102);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(216, 26);
            this.txtId.TabIndex = 82;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(54, 101);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(80, 25);
            this.lblCedula.TabIndex = 83;
            this.lblCedula.Text = "Cedula";
            this.lblCedula.Click += new System.EventHandler(this.lblUsuarioNuevo_Click);
            // 
            // lblContraseñaNueva
            // 
            this.lblContraseñaNueva.AutoSize = true;
            this.lblContraseñaNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaNueva.Location = new System.Drawing.Point(273, 300);
            this.lblContraseñaNueva.Name = "lblContraseñaNueva";
            this.lblContraseñaNueva.Size = new System.Drawing.Size(123, 25);
            this.lblContraseñaNueva.TabIndex = 84;
            this.lblContraseñaNueva.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(405, 301);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(127, 26);
            this.txtContrasena.TabIndex = 85;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(55, 363);
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
            this.btnSalir.Location = new System.Drawing.Point(701, 363);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 45);
            this.btnSalir.TabIndex = 89;
            this.btnSalir.Text = "Atrás";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtConfirmarContrasena
            // 
            this.txtConfirmarContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarContrasena.Location = new System.Drawing.Point(695, 300);
            this.txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            this.txtConfirmarContrasena.PasswordChar = '*';
            this.txtConfirmarContrasena.Size = new System.Drawing.Size(127, 26);
            this.txtConfirmarContrasena.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(551, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 57);
            this.label1.TabIndex = 90;
            this.label1.Text = "Confirme su contraseña";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(50, 298);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(77, 25);
            this.lblCorreo.TabIndex = 94;
            this.lblCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(135, 300);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(127, 26);
            this.txtCorreo.TabIndex = 93;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(214, 363);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(121, 45);
            this.btnLimpiar.TabIndex = 96;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblDistrito
            // 
            this.lblDistrito.AutoSize = true;
            this.lblDistrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrito.Location = new System.Drawing.Point(586, 222);
            this.lblDistrito.Name = "lblDistrito";
            this.lblDistrito.Size = new System.Drawing.Size(79, 25);
            this.lblDistrito.TabIndex = 101;
            this.lblDistrito.Text = "Distrito";
            // 
            // lblCanton
            // 
            this.lblCanton.AutoSize = true;
            this.lblCanton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanton.Location = new System.Drawing.Point(331, 221);
            this.lblCanton.Name = "lblCanton";
            this.lblCanton.Size = new System.Drawing.Size(81, 25);
            this.lblCanton.TabIndex = 99;
            this.lblCanton.Text = "Canton";
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
            this.cmbProvincia.Location = new System.Drawing.Point(170, 225);
            this.cmbProvincia.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(146, 21);
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
            this.cmbCanton.Location = new System.Drawing.Point(427, 225);
            this.cmbCanton.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCanton.Name = "cmbCanton";
            this.cmbCanton.Size = new System.Drawing.Size(146, 21);
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
            this.cmbDistrito.Location = new System.Drawing.Point(679, 224);
            this.cmbDistrito.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDistrito.Name = "cmbDistrito";
            this.cmbDistrito.Size = new System.Drawing.Size(146, 21);
            this.cmbDistrito.TabIndex = 105;
            this.cmbDistrito.SelectedIndexChanged += new System.EventHandler(this.cmbDistrito_SelectedIndexChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(54, 158);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 107;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(151, 158);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(137, 26);
            this.txtNombre.TabIndex = 106;
            // 
            // lblApellido1
            // 
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido1.Location = new System.Drawing.Point(315, 160);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(107, 25);
            this.lblApellido1.TabIndex = 110;
            this.lblApellido1.Text = "Apellido 1";
            // 
            // textApellido1
            // 
            this.textApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellido1.Location = new System.Drawing.Point(428, 159);
            this.textApellido1.Name = "textApellido1";
            this.textApellido1.ReadOnly = true;
            this.textApellido1.Size = new System.Drawing.Size(137, 26);
            this.textApellido1.TabIndex = 109;
            // 
            // lblApellido2
            // 
            this.lblApellido2.AutoSize = true;
            this.lblApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido2.Location = new System.Drawing.Point(575, 161);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(107, 25);
            this.lblApellido2.TabIndex = 113;
            this.lblApellido2.Text = "Apellido 2";
            // 
            // txtApellido2
            // 
            this.txtApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido2.Location = new System.Drawing.Point(688, 160);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.ReadOnly = true;
            this.txtApellido2.Size = new System.Drawing.Size(137, 26);
            this.txtApellido2.TabIndex = 112;
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVencimiento.Location = new System.Drawing.Point(546, 102);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(280, 22);
            this.dtpVencimiento.TabIndex = 118;
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimiento.Location = new System.Drawing.Point(399, 99);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(130, 25);
            this.lblVencimiento.TabIndex = 122;
            this.lblVencimiento.Text = "Vencimiento";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(54, 222);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(101, 25);
            this.lblProvincia.TabIndex = 98;
            this.lblProvincia.Text = "Provincia";
            // 
            // frmCredenciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(892, 440);
            this.ControlBox = false;
            this.Controls.Add(this.lblVencimiento);
            this.Controls.Add(this.dtpVencimiento);
            this.Controls.Add(this.lblApellido2);
            this.Controls.Add(this.txtApellido2);
            this.Controls.Add(this.lblApellido1);
            this.Controls.Add(this.textApellido1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbDistrito);
            this.Controls.Add(this.cmbCanton);
            this.Controls.Add(this.cmbProvincia);
            this.Controls.Add(this.lblDistrito);
            this.Controls.Add(this.lblCanton);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtConfirmarContrasena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.lblContraseñaNueva);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblCredenciales);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCredenciales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credenciales";
            this.Load += new System.EventHandler(this.frmCredenciales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCredenciales;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblContraseñaNueva;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtConfirmarContrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblDistrito;
        private System.Windows.Forms.Label lblCanton;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.ComboBox cmbCanton;
        private System.Windows.Forms.ComboBox cmbDistrito;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.TextBox textApellido1;
        private System.Windows.Forms.Label lblApellido2;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.Label lblProvincia;
    }
}