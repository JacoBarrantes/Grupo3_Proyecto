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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistritoElectoral)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoElectoral
            // 
            this.lblCodigoElectoral.AutoSize = true;
            this.lblCodigoElectoral.Location = new System.Drawing.Point(37, 43);
            this.lblCodigoElectoral.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoElectoral.Name = "lblCodigoElectoral";
            this.lblCodigoElectoral.Size = new System.Drawing.Size(84, 13);
            this.lblCodigoElectoral.TabIndex = 0;
            this.lblCodigoElectoral.Text = "Codigo Electoral";
            // 
            // Provincia
            // 
            this.Provincia.AutoSize = true;
            this.Provincia.Location = new System.Drawing.Point(37, 90);
            this.Provincia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Provincia.Name = "Provincia";
            this.Provincia.Size = new System.Drawing.Size(51, 13);
            this.Provincia.TabIndex = 1;
            this.Provincia.Text = "Provincia";
            // 
            // lblCanton
            // 
            this.lblCanton.AutoSize = true;
            this.lblCanton.Location = new System.Drawing.Point(310, 43);
            this.lblCanton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCanton.Name = "lblCanton";
            this.lblCanton.Size = new System.Drawing.Size(41, 13);
            this.lblCanton.TabIndex = 2;
            this.lblCanton.Text = "Canton";
            // 
            // lblDistrito
            // 
            this.lblDistrito.AutoSize = true;
            this.lblDistrito.Location = new System.Drawing.Point(310, 90);
            this.lblDistrito.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDistrito.Name = "lblDistrito";
            this.lblDistrito.Size = new System.Drawing.Size(39, 13);
            this.lblDistrito.TabIndex = 3;
            this.lblDistrito.Text = "Distrito";
            // 
            // txtCodigoElectoral
            // 
            this.txtCodigoElectoral.Location = new System.Drawing.Point(122, 38);
            this.txtCodigoElectoral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigoElectoral.Name = "txtCodigoElectoral";
            this.txtCodigoElectoral.Size = new System.Drawing.Size(139, 20);
            this.txtCodigoElectoral.TabIndex = 4;
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(88, 85);
            this.txtProvincia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(139, 20);
            this.txtProvincia.TabIndex = 5;
            // 
            // txtCanton
            // 
            this.txtCanton.Location = new System.Drawing.Point(351, 38);
            this.txtCanton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCanton.Name = "txtCanton";
            this.txtCanton.Size = new System.Drawing.Size(139, 20);
            this.txtCanton.TabIndex = 6;
            // 
            // txtDistrito
            // 
            this.txtDistrito.Location = new System.Drawing.Point(350, 85);
            this.txtDistrito.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDistrito.Name = "txtDistrito";
            this.txtDistrito.Size = new System.Drawing.Size(139, 20);
            this.txtDistrito.TabIndex = 7;
            // 
            // dgvDistritoElectoral
            // 
            this.dgvDistritoElectoral.AllowUserToAddRows = false;
            this.dgvDistritoElectoral.AllowUserToDeleteRows = false;
            this.dgvDistritoElectoral.AllowUserToResizeColumns = false;
            this.dgvDistritoElectoral.AllowUserToResizeRows = false;
            this.dgvDistritoElectoral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDistritoElectoral.Location = new System.Drawing.Point(39, 156);
            this.dgvDistritoElectoral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDistritoElectoral.MultiSelect = false;
            this.dgvDistritoElectoral.Name = "dgvDistritoElectoral";
            this.dgvDistritoElectoral.ReadOnly = true;
            this.dgvDistritoElectoral.RowHeadersWidth = 51;
            this.dgvDistritoElectoral.RowTemplate.Height = 24;
            this.dgvDistritoElectoral.Size = new System.Drawing.Size(510, 72);
            this.dgvDistritoElectoral.TabIndex = 8;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(39, 265);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(98, 34);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(171, 265);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 34);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(298, 265);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(98, 34);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(452, 265);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(98, 34);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmDistritoElectoral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}