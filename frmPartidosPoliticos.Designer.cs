namespace grupo3_Proyecto
{
    partial class frmPartidosPoliticos
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
            this.lblPartido = new System.Windows.Forms.Label();
            this.lblIdPartido = new System.Windows.Forms.Label();
            this.lblBandera = new System.Windows.Forms.Label();
            this.txtRutaBandera = new System.Windows.Forms.TextBox();
            this.txtIdPartido = new System.Windows.Forms.TextBox();
            this.txtNombrePartido = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscarImagen = new System.Windows.Forms.Button();
            this.dgvPartidos = new System.Windows.Forms.DataGridView();
            this.picBandera = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBandera)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPartido
            // 
            this.lblPartido.AutoSize = true;
            this.lblPartido.Location = new System.Drawing.Point(384, 67);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(123, 16);
            this.lblPartido.TabIndex = 0;
            this.lblPartido.Text = "Nombre del partido";
            // 
            // lblIdPartido
            // 
            this.lblIdPartido.AutoSize = true;
            this.lblIdPartido.Location = new System.Drawing.Point(27, 67);
            this.lblIdPartido.Name = "lblIdPartido";
            this.lblIdPartido.Size = new System.Drawing.Size(87, 16);
            this.lblIdPartido.TabIndex = 1;
            this.lblIdPartido.Text = "ID del partido";
            // 
            // lblBandera
            // 
            this.lblBandera.AutoSize = true;
            this.lblBandera.Location = new System.Drawing.Point(27, 167);
            this.lblBandera.Name = "lblBandera";
            this.lblBandera.Size = new System.Drawing.Size(121, 16);
            this.lblBandera.TabIndex = 2;
            this.lblBandera.Text = "Ruta local bandera";
            // 
            // txtRutaBandera
            // 
            this.txtRutaBandera.Location = new System.Drawing.Point(154, 161);
            this.txtRutaBandera.Name = "txtRutaBandera";
            this.txtRutaBandera.Size = new System.Drawing.Size(189, 22);
            this.txtRutaBandera.TabIndex = 3;
            // 
            // txtIdPartido
            // 
            this.txtIdPartido.Location = new System.Drawing.Point(120, 61);
            this.txtIdPartido.Name = "txtIdPartido";
            this.txtIdPartido.Size = new System.Drawing.Size(189, 22);
            this.txtIdPartido.TabIndex = 4;
            this.txtIdPartido.TextChanged += new System.EventHandler(this.txtIdPartido_TextChanged);
            // 
            // txtNombrePartido
            // 
            this.txtNombrePartido.Location = new System.Drawing.Point(541, 67);
            this.txtNombrePartido.Name = "txtNombrePartido";
            this.txtNombrePartido.Size = new System.Drawing.Size(189, 22);
            this.txtNombrePartido.TabIndex = 5;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(602, 394);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(110, 44);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Limpiar";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(199, 394);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 44);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(387, 394);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 44);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscarImagen
            // 
            this.btnBuscarImagen.Location = new System.Drawing.Point(30, 394);
            this.btnBuscarImagen.Name = "btnBuscarImagen";
            this.btnBuscarImagen.Size = new System.Drawing.Size(110, 44);
            this.btnBuscarImagen.TabIndex = 10;
            this.btnBuscarImagen.Text = "Buscar Imagen";
            this.btnBuscarImagen.UseVisualStyleBackColor = true;
            this.btnBuscarImagen.Click += new System.EventHandler(this.btnBuscarImagen_Click);
            // 
            // dgvPartidos
            // 
            this.dgvPartidos.AllowUserToDeleteRows = false;
            this.dgvPartidos.AllowUserToResizeColumns = false;
            this.dgvPartidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPartidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartidos.Location = new System.Drawing.Point(30, 242);
            this.dgvPartidos.MultiSelect = false;
            this.dgvPartidos.Name = "dgvPartidos";
            this.dgvPartidos.ReadOnly = true;
            this.dgvPartidos.RowHeadersVisible = false;
            this.dgvPartidos.RowHeadersWidth = 51;
            this.dgvPartidos.RowTemplate.Height = 24;
            this.dgvPartidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPartidos.Size = new System.Drawing.Size(682, 131);
            this.dgvPartidos.TabIndex = 11;
            this.dgvPartidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPartidos_CellContentClick);
            // 
            // picBandera
            // 
            this.picBandera.Location = new System.Drawing.Point(387, 129);
            this.picBandera.Name = "picBandera";
            this.picBandera.Size = new System.Drawing.Size(260, 81);
            this.picBandera.TabIndex = 6;
            this.picBandera.TabStop = false;
            // 
            // frmPartidosPoliticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPartidos);
            this.Controls.Add(this.btnBuscarImagen);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.picBandera);
            this.Controls.Add(this.txtNombrePartido);
            this.Controls.Add(this.txtIdPartido);
            this.Controls.Add(this.txtRutaBandera);
            this.Controls.Add(this.lblBandera);
            this.Controls.Add(this.lblIdPartido);
            this.Controls.Add(this.lblPartido);
            this.Name = "frmPartidosPoliticos";
            this.Text = "frmPartidosPoliticos";
            this.Load += new System.EventHandler(this.frmPartidosPoliticos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBandera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPartido;
        private System.Windows.Forms.Label lblIdPartido;
        private System.Windows.Forms.Label lblBandera;
        private System.Windows.Forms.TextBox txtRutaBandera;
        private System.Windows.Forms.TextBox txtIdPartido;
        private System.Windows.Forms.TextBox txtNombrePartido;
        private System.Windows.Forms.PictureBox picBandera;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscarImagen;
        private System.Windows.Forms.DataGridView dgvPartidos;
    }
}