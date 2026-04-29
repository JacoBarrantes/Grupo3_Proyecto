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
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(126, 34);
            this.lblProvincia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(144, 15);
            this.lblProvincia.TabIndex = 0;
            this.lblProvincia.Text = "Informe por Provincia";
            // 
            // btnActualizarProvincia
            // 
            this.btnActualizarProvincia.AutoSize = true;
            this.btnActualizarProvincia.Location = new System.Drawing.Point(526, 14);
            this.btnActualizarProvincia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizarProvincia.Name = "btnActualizarProvincia";
            this.btnActualizarProvincia.Size = new System.Drawing.Size(90, 40);
            this.btnActualizarProvincia.TabIndex = 1;
            this.btnActualizarProvincia.Text = "Actualizar";
            this.btnActualizarProvincia.UseVisualStyleBackColor = true;
            this.btnActualizarProvincia.Click += new System.EventHandler(this.btnActualizarProvincia_Click);
            // 
            // dgvProvincia
            // 
            this.dgvProvincia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvincia.Location = new System.Drawing.Point(48, 62);
            this.dgvProvincia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvProvincia.Name = "dgvProvincia";
            this.dgvProvincia.Size = new System.Drawing.Size(760, 167);
            this.dgvProvincia.TabIndex = 2;
            // 
            // dgvCandidato
            // 
            this.dgvCandidato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidato.Location = new System.Drawing.Point(48, 310);
            this.dgvCandidato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCandidato.Name = "dgvCandidato";
            this.dgvCandidato.Size = new System.Drawing.Size(760, 195);
            this.dgvCandidato.TabIndex = 3;
            // 
            // btnActualizarCandidato
            // 
            this.btnActualizarCandidato.AutoSize = true;
            this.btnActualizarCandidato.Location = new System.Drawing.Point(526, 251);
            this.btnActualizarCandidato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizarCandidato.Name = "btnActualizarCandidato";
            this.btnActualizarCandidato.Size = new System.Drawing.Size(108, 39);
            this.btnActualizarCandidato.TabIndex = 4;
            this.btnActualizarCandidato.Text = "Actualizar";
            this.btnActualizarCandidato.UseVisualStyleBackColor = true;
            this.btnActualizarCandidato.Click += new System.EventHandler(this.btnActualizarCandidato_Click);
            // 
            // lblCandidato
            // 
            this.lblCandidato.AutoSize = true;
            this.lblCandidato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandidato.Location = new System.Drawing.Point(126, 256);
            this.lblCandidato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCandidato.Name = "lblCandidato";
            this.lblCandidato.Size = new System.Drawing.Size(150, 15);
            this.lblCandidato.TabIndex = 5;
            this.lblCandidato.Text = "Informe por Candidato";
            // 
            // frmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 519);
            this.Controls.Add(this.lblCandidato);
            this.Controls.Add(this.btnActualizarCandidato);
            this.Controls.Add(this.dgvCandidato);
            this.Controls.Add(this.dgvProvincia);
            this.Controls.Add(this.btnActualizarProvincia);
            this.Controls.Add(this.lblProvincia);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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