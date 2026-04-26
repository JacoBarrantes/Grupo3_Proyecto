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
            this.lblCedula.Location = new System.Drawing.Point(24, 28);
            this.lblCedula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(40, 13);
            this.lblCedula.TabIndex = 0;
            this.lblCedula.Text = "Cedula";
            // 
            // lblCodigoElectoral
            // 
            this.lblCodigoElectoral.AutoSize = true;
            this.lblCodigoElectoral.Location = new System.Drawing.Point(188, 28);
            this.lblCodigoElectoral.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoElectoral.Name = "lblCodigoElectoral";
            this.lblCodigoElectoral.Size = new System.Drawing.Size(84, 13);
            this.lblCodigoElectoral.TabIndex = 1;
            this.lblCodigoElectoral.Text = "Codigo Electoral";
            // 
            // lblJunta
            // 
            this.lblJunta.AutoSize = true;
            this.lblJunta.Location = new System.Drawing.Point(592, 101);
            this.lblJunta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJunta.Name = "lblJunta";
            this.lblJunta.Size = new System.Drawing.Size(33, 13);
            this.lblJunta.TabIndex = 2;
            this.lblJunta.Text = "Junta";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(24, 101);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido1
            // 
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Location = new System.Drawing.Point(188, 101);
            this.lblApellido1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(53, 13);
            this.lblApellido1.TabIndex = 4;
            this.lblApellido1.Text = "Apellido 1";
            // 
            // lblApellido2
            // 
            this.lblApellido2.AutoSize = true;
            this.lblApellido2.Location = new System.Drawing.Point(403, 101);
            this.lblApellido2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(53, 13);
            this.lblApellido2.TabIndex = 5;
            this.lblApellido2.Text = "Apellido 2";
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Location = new System.Drawing.Point(544, 27);
            this.dtpVencimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(190, 20);
            this.dtpVencimiento.TabIndex = 6;
            this.dtpVencimiento.ValueChanged += new System.EventHandler(this.dtpVencimientoCedula_ValueChanged);
            // 
            // dgvPadron
            // 
            this.dgvPadron.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPadron.Location = new System.Drawing.Point(17, 126);
            this.dgvPadron.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPadron.Name = "dgvPadron";
            this.dgvPadron.RowHeadersWidth = 51;
            this.dgvPadron.RowTemplate.Height = 24;
            this.dgvPadron.Size = new System.Drawing.Size(716, 171);
            this.dgvPadron.TabIndex = 7;
            this.dgvPadron.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPadron_CellContentClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(624, 325);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 39);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(17, 325);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(110, 39);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(209, 325);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 39);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(422, 325);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(110, 39);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(66, 28);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(108, 20);
            this.txtCedula.TabIndex = 12;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            // 
            // txtCodigoElectoral
            // 
            this.txtCodigoElectoral.Location = new System.Drawing.Point(275, 24);
            this.txtCodigoElectoral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigoElectoral.Name = "txtCodigoElectoral";
            this.txtCodigoElectoral.Size = new System.Drawing.Size(108, 20);
            this.txtCodigoElectoral.TabIndex = 13;
            this.txtCodigoElectoral.TextChanged += new System.EventHandler(this.txtCodigoElectoral_TextChanged);
            // 
            // txtJunta
            // 
            this.txtJunta.Location = new System.Drawing.Point(626, 96);
            this.txtJunta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtJunta.Name = "txtJunta";
            this.txtJunta.Size = new System.Drawing.Size(108, 20);
            this.txtJunta.TabIndex = 14;
            this.txtJunta.TextChanged += new System.EventHandler(this.txtJunta_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(70, 96);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(108, 20);
            this.txtNombre.TabIndex = 15;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(243, 96);
            this.txtApellido1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(108, 20);
            this.txtApellido1.TabIndex = 16;
            this.txtApellido1.TextChanged += new System.EventHandler(this.txtApellido1_TextChanged);
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(458, 96);
            this.txtApellido2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(108, 20);
            this.txtApellido2.TabIndex = 17;
            this.txtApellido2.TextChanged += new System.EventHandler(this.txtApellido2_TextChanged);
            // 
            // lblFechaVencimientoCed
            // 
            this.lblFechaVencimientoCed.AutoSize = true;
            this.lblFechaVencimientoCed.Location = new System.Drawing.Point(406, 31);
            this.lblFechaVencimientoCed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaVencimientoCed.Name = "lblFechaVencimientoCed";
            this.lblFechaVencimientoCed.Size = new System.Drawing.Size(134, 13);
            this.lblFechaVencimientoCed.TabIndex = 18;
            this.lblFechaVencimientoCed.Text = "Fecha Vencimiento Cedula";
            // 
            // frmPadronNacional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 366);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPadronNacional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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