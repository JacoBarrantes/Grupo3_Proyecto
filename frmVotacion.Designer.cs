namespace grupo3_Proyecto
{
    partial class frmVotacion
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
            this.lblTipoEleccion = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.dgvCandidatos = new System.Windows.Forms.DataGridView();
            this.btnConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoEleccion
            // 
            this.lblTipoEleccion.AutoSize = true;
            this.lblTipoEleccion.Location = new System.Drawing.Point(74, 50);
            this.lblTipoEleccion.Name = "lblTipoEleccion";
            this.lblTipoEleccion.Size = new System.Drawing.Size(108, 16);
            this.lblTipoEleccion.TabIndex = 0;
            this.lblTipoEleccion.Text = "Tipo de eleccion";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(489, 50);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(54, 16);
            this.lblTiempo.TabIndex = 1;
            this.lblTiempo.Text = "Tiempo";
            // 
            // dgvCandidatos
            // 
            this.dgvCandidatos.AllowUserToAddRows = false;
            this.dgvCandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidatos.Location = new System.Drawing.Point(77, 90);
            this.dgvCandidatos.MultiSelect = false;
            this.dgvCandidatos.Name = "dgvCandidatos";
            this.dgvCandidatos.ReadOnly = true;
            this.dgvCandidatos.RowHeadersWidth = 51;
            this.dgvCandidatos.RowTemplate.Height = 24;
            this.dgvCandidatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCandidatos.Size = new System.Drawing.Size(752, 297);
            this.dgvCandidatos.TabIndex = 2;
            this.dgvCandidatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCandidatos_CellContentClick);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(370, 393);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(108, 45);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // frmVotacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.dgvCandidatos);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblTipoEleccion);
            this.Name = "frmVotacion";
            this.Text = "frmVotacion";
            this.Load += new System.EventHandler(this.frmVotacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoEleccion;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.DataGridView dgvCandidatos;
        private System.Windows.Forms.Button btnConfirmar;
    }
}