namespace grupo3_Proyecto
{
    partial class frmDistritoElectoral
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
            this.lblCodigoElectoral = new System.Windows.Forms.Label();
            this.Provincia = new System.Windows.Forms.Label();
            this.lblCanton = new System.Windows.Forms.Label();
            this.lblDistrito = new System.Windows.Forms.Label();
            this.txtCodigoElectoral = new System.Windows.Forms.TextBox();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.txtCanton = new System.Windows.Forms.TextBox();
            this.txtDistrito = new System.Windows.Forms.TextBox();
            this.dgvDistritoElectoral = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtCrearUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistritoElectoral)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoElectoral
            // 
            this.lblCodigoElectoral.AutoSize = true;
            this.lblCodigoElectoral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoElectoral.Location = new System.Drawing.Point(53, 99);
            this.lblCodigoElectoral.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoElectoral.Name = "lblCodigoElectoral";
            this.lblCodigoElectoral.Size = new System.Drawing.Size(141, 20);
            this.lblCodigoElectoral.TabIndex = 0;
            this.lblCodigoElectoral.Text = "Codigo Electoral";
            // 
            // Provincia
            // 
            this.Provincia.AutoSize = true;
            this.Provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Provincia.Location = new System.Drawing.Point(53, 146);
            this.Provincia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Provincia.Name = "Provincia";
            this.Provincia.Size = new System.Drawing.Size(81, 20);
            this.Provincia.TabIndex = 1;
            this.Provincia.Text = "Provincia";
            // 
            // lblCanton
            // 
            this.lblCanton.AutoSize = true;
            this.lblCanton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanton.Location = new System.Drawing.Point(368, 99);
            this.lblCanton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCanton.Name = "lblCanton";
            this.lblCanton.Size = new System.Drawing.Size(67, 20);
            this.lblCanton.TabIndex = 2;
            this.lblCanton.Text = "Cantón";
            // 
            // lblDistrito
            // 
            this.lblDistrito.AutoSize = true;
            this.lblDistrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrito.Location = new System.Drawing.Point(368, 146);
            this.lblDistrito.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDistrito.Name = "lblDistrito";
            this.lblDistrito.Size = new System.Drawing.Size(67, 20);
            this.lblDistrito.TabIndex = 3;
            this.lblDistrito.Text = "Distrito";
            // 
            // txtCodigoElectoral
            // 
            this.txtCodigoElectoral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoElectoral.Location = new System.Drawing.Point(200, 96);
            this.txtCodigoElectoral.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoElectoral.Name = "txtCodigoElectoral";
            this.txtCodigoElectoral.Size = new System.Drawing.Size(139, 26);
            this.txtCodigoElectoral.TabIndex = 4;
            // 
            // txtProvincia
            // 
            this.txtProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvincia.Location = new System.Drawing.Point(200, 143);
            this.txtProvincia.Margin = new System.Windows.Forms.Padding(2);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(139, 26);
            this.txtProvincia.TabIndex = 5;
            // 
            // txtCanton
            // 
            this.txtCanton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCanton.Location = new System.Drawing.Point(453, 96);
            this.txtCanton.Margin = new System.Windows.Forms.Padding(2);
            this.txtCanton.Name = "txtCanton";
            this.txtCanton.Size = new System.Drawing.Size(139, 26);
            this.txtCanton.TabIndex = 6;
            // 
            // txtDistrito
            // 
            this.txtDistrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistrito.Location = new System.Drawing.Point(452, 143);
            this.txtDistrito.Margin = new System.Windows.Forms.Padding(2);
            this.txtDistrito.Name = "txtDistrito";
            this.txtDistrito.Size = new System.Drawing.Size(139, 26);
            this.txtDistrito.TabIndex = 7;
            // 
            // dgvDistritoElectoral
            // 
            this.dgvDistritoElectoral.AllowUserToAddRows = false;
            this.dgvDistritoElectoral.AllowUserToDeleteRows = false;
            this.dgvDistritoElectoral.AllowUserToResizeColumns = false;
            this.dgvDistritoElectoral.AllowUserToResizeRows = false;
            this.dgvDistritoElectoral.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDistritoElectoral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDistritoElectoral.Location = new System.Drawing.Point(55, 197);
            this.dgvDistritoElectoral.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDistritoElectoral.MultiSelect = false;
            this.dgvDistritoElectoral.Name = "dgvDistritoElectoral";
            this.dgvDistritoElectoral.ReadOnly = true;
            this.dgvDistritoElectoral.RowHeadersWidth = 51;
            this.dgvDistritoElectoral.RowTemplate.Height = 24;
            this.dgvDistritoElectoral.Size = new System.Drawing.Size(537, 105);
            this.dgvDistritoElectoral.TabIndex = 8;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(57, 334);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(98, 34);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(200, 334);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 34);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(351, 334);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(98, 34);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(489, 334);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(98, 34);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtCrearUsuario
            // 
            this.txtCrearUsuario.AutoSize = true;
            this.txtCrearUsuario.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrearUsuario.Location = new System.Drawing.Point(177, 25);
            this.txtCrearUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtCrearUsuario.Name = "txtCrearUsuario";
            this.txtCrearUsuario.Size = new System.Drawing.Size(284, 36);
            this.txtCrearUsuario.TabIndex = 114;
            this.txtCrearUsuario.Text = "Distrito Electoral";
            // 
            // frmDistritoElectoral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(652, 395);
            this.ControlBox = false;
            this.Controls.Add(this.txtCrearUsuario);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvDistritoElectoral);
            this.Controls.Add(this.txtDistrito);
            this.Controls.Add(this.txtCanton);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.txtCodigoElectoral);
            this.Controls.Add(this.lblDistrito);
            this.Controls.Add(this.lblCanton);
            this.Controls.Add(this.Provincia);
            this.Controls.Add(this.lblCodigoElectoral);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDistritoElectoral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDistritoElectoral";
            this.Load += new System.EventHandler(this.frmDistritoElectoral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistritoElectoral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoElectoral;
        private System.Windows.Forms.Label Provincia;
        private System.Windows.Forms.Label lblCanton;
        private System.Windows.Forms.Label lblDistrito;
        private System.Windows.Forms.TextBox txtCodigoElectoral;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.TextBox txtCanton;
        private System.Windows.Forms.TextBox txtDistrito;
        private System.Windows.Forms.DataGridView dgvDistritoElectoral;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label txtCrearUsuario;
    }
}