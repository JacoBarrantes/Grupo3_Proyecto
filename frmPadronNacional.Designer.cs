namespace grupo3_Proyecto
{
    partial class frmPadronNacional
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
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblCodigoElectoral = new System.Windows.Forms.Label();
            this.lblJunta = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.lblApellido2 = new System.Windows.Forms.Label();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.dgvPadron = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtCodigoElectoral = new System.Windows.Forms.TextBox();
            this.txtJunta = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.lblFechaVencimientoCed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPadron)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(32, 35);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(50, 16);
            this.lblCedula.TabIndex = 0;
            this.lblCedula.Text = "Cedula";
            // 
            // lblCodigoElectoral
            // 
            this.lblCodigoElectoral.AutoSize = true;
            this.lblCodigoElectoral.Location = new System.Drawing.Point(251, 35);
            this.lblCodigoElectoral.Name = "lblCodigoElectoral";
            this.lblCodigoElectoral.Size = new System.Drawing.Size(107, 16);
            this.lblCodigoElectoral.TabIndex = 1;
            this.lblCodigoElectoral.Text = "Codigo Electoral";
            // 
            // lblJunta
            // 
            this.lblJunta.AutoSize = true;
            this.lblJunta.Location = new System.Drawing.Point(790, 124);
            this.lblJunta.Name = "lblJunta";
            this.lblJunta.Size = new System.Drawing.Size(39, 16);
            this.lblJunta.TabIndex = 2;
            this.lblJunta.Text = "Junta";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(32, 124);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido1
            // 
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Location = new System.Drawing.Point(251, 124);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(67, 16);
            this.lblApellido1.TabIndex = 4;
            this.lblApellido1.Text = "Apellido 1";
            // 
            // lblApellido2
            // 
            this.lblApellido2.AutoSize = true;
            this.lblApellido2.Location = new System.Drawing.Point(537, 124);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(67, 16);
            this.lblApellido2.TabIndex = 5;
            this.lblApellido2.Text = "Apellido 2";
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Location = new System.Drawing.Point(726, 33);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(252, 22);
            this.dtpVencimiento.TabIndex = 6;
            this.dtpVencimiento.ValueChanged += new System.EventHandler(this.dtpVencimientoCedula_ValueChanged);
            // 
            // dgvPadron
            // 
            this.dgvPadron.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPadron.Location = new System.Drawing.Point(23, 155);
            this.dgvPadron.Name = "dgvPadron";
            this.dgvPadron.RowHeadersWidth = 51;
            this.dgvPadron.RowTemplate.Height = 24;
            this.dgvPadron.Size = new System.Drawing.Size(955, 210);
            this.dgvPadron.TabIndex = 7;
            this.dgvPadron.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPadron_CellContentClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(832, 400);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(146, 48);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(23, 400);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(146, 48);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(279, 400);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(146, 48);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(563, 400);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(146, 48);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(88, 35);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(143, 22);
            this.txtCedula.TabIndex = 12;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            // 
            // txtCodigoElectoral
            // 
            this.txtCodigoElectoral.Location = new System.Drawing.Point(367, 29);
            this.txtCodigoElectoral.Name = "txtCodigoElectoral";
            this.txtCodigoElectoral.Size = new System.Drawing.Size(143, 22);
            this.txtCodigoElectoral.TabIndex = 13;
            this.txtCodigoElectoral.TextChanged += new System.EventHandler(this.txtCodigoElectoral_TextChanged);
            // 
            // txtJunta
            // 
            this.txtJunta.Location = new System.Drawing.Point(835, 118);
            this.txtJunta.Name = "txtJunta";
            this.txtJunta.Size = new System.Drawing.Size(143, 22);
            this.txtJunta.TabIndex = 14;
            this.txtJunta.TextChanged += new System.EventHandler(this.txtJunta_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(94, 118);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(143, 22);
            this.txtNombre.TabIndex = 15;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(324, 118);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(143, 22);
            this.txtApellido1.TabIndex = 16;
            this.txtApellido1.TextChanged += new System.EventHandler(this.txtApellido1_TextChanged);
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(610, 118);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(143, 22);
            this.txtApellido2.TabIndex = 17;
            this.txtApellido2.TextChanged += new System.EventHandler(this.txtApellido2_TextChanged);
            // 
            // lblFechaVencimientoCed
            // 
            this.lblFechaVencimientoCed.AutoSize = true;
            this.lblFechaVencimientoCed.Location = new System.Drawing.Point(541, 38);
            this.lblFechaVencimientoCed.Name = "lblFechaVencimientoCed";
            this.lblFechaVencimientoCed.Size = new System.Drawing.Size(168, 16);
            this.lblFechaVencimientoCed.TabIndex = 18;
            this.lblFechaVencimientoCed.Text = "Fecha Vencimiento Cedula";
            // 
            // frmPadronNacional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 450);
            this.Controls.Add(this.lblFechaVencimientoCed);
            this.Controls.Add(this.txtApellido2);
            this.Controls.Add(this.txtApellido1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtJunta);
            this.Controls.Add(this.txtCodigoElectoral);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvPadron);
            this.Controls.Add(this.dtpVencimiento);
            this.Controls.Add(this.lblApellido2);
            this.Controls.Add(this.lblApellido1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblJunta);
            this.Controls.Add(this.lblCodigoElectoral);
            this.Controls.Add(this.lblCedula);
            this.Name = "frmPadronNacional";
            this.Text = "frmPadronNacional";
            this.Load += new System.EventHandler(this.frmPadronNacional_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPadron)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblCodigoElectoral;
        private System.Windows.Forms.Label lblJunta;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.Label lblApellido2;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.DataGridView dgvPadron;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtCodigoElectoral;
        private System.Windows.Forms.TextBox txtJunta;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.Label lblFechaVencimientoCed;
    }
}