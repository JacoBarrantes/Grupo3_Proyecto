namespace grupo3_Proyecto
{
    partial class frmInformes
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
            this.lblProvincia = new System.Windows.Forms.Label();
            this.btnActualizarProvincia = new System.Windows.Forms.Button();
            this.dgvProvincia = new System.Windows.Forms.DataGridView();
            this.dgvCandidato = new System.Windows.Forms.DataGridView();
            this.btnActualizarCandidato = new System.Windows.Forms.Button();
            this.lblCandidato = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvincia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidato)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(94, 30);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(107, 13);
            this.lblProvincia.TabIndex = 0;
            this.lblProvincia.Text = "Informe por Provincia";
            // 
            // btnActualizarProvincia
            // 
            this.btnActualizarProvincia.AutoSize = true;
            this.btnActualizarProvincia.Location = new System.Drawing.Point(395, 12);
            this.btnActualizarProvincia.Name = "btnActualizarProvincia";
            this.btnActualizarProvincia.Size = new System.Drawing.Size(68, 35);
            this.btnActualizarProvincia.TabIndex = 1;
            this.btnActualizarProvincia.Text = "Actualizar";
            this.btnActualizarProvincia.UseVisualStyleBackColor = true;
            this.btnActualizarProvincia.Click += new System.EventHandler(this.btnActualizarProvincia_Click);
            // 
            // dgvProvincia
            // 
            this.dgvProvincia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvincia.Location = new System.Drawing.Point(36, 53);
            this.dgvProvincia.Name = "dgvProvincia";
            this.dgvProvincia.Size = new System.Drawing.Size(570, 145);
            this.dgvProvincia.TabIndex = 2;
            // 
            // dgvCandidato
            // 
            this.dgvCandidato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidato.Location = new System.Drawing.Point(36, 269);
            this.dgvCandidato.Name = "dgvCandidato";
            this.dgvCandidato.Size = new System.Drawing.Size(570, 169);
            this.dgvCandidato.TabIndex = 3;
            // 
            // btnActualizarCandidato
            // 
            this.btnActualizarCandidato.AutoSize = true;
            this.btnActualizarCandidato.Location = new System.Drawing.Point(395, 218);
            this.btnActualizarCandidato.Name = "btnActualizarCandidato";
            this.btnActualizarCandidato.Size = new System.Drawing.Size(81, 34);
            this.btnActualizarCandidato.TabIndex = 4;
            this.btnActualizarCandidato.Text = "Actualizar";
            this.btnActualizarCandidato.UseVisualStyleBackColor = true;
            this.btnActualizarCandidato.Click += new System.EventHandler(this.btnActualizarCandidato_Click);
            // 
            // lblCandidato
            // 
            this.lblCandidato.AutoSize = true;
            this.lblCandidato.Location = new System.Drawing.Point(94, 222);
            this.lblCandidato.Name = "lblCandidato";
            this.lblCandidato.Size = new System.Drawing.Size(111, 13);
            this.lblCandidato.TabIndex = 5;
            this.lblCandidato.Text = "Informe por Candidato";
            // 
            // frmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCandidato);
            this.Controls.Add(this.btnActualizarCandidato);
            this.Controls.Add(this.dgvCandidato);
            this.Controls.Add(this.dgvProvincia);
            this.Controls.Add(this.btnActualizarProvincia);
            this.Controls.Add(this.lblProvincia);
            this.Name = "frmInformes";
            this.Text = "Informes Provincia y Candidato";
            this.Load += new System.EventHandler(this.frmInformes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvincia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Button btnActualizarProvincia;
        private System.Windows.Forms.DataGridView dgvProvincia;
        private System.Windows.Forms.DataGridView dgvCandidato;
        private System.Windows.Forms.Button btnActualizarCandidato;
        private System.Windows.Forms.Label lblCandidato;
    }
}