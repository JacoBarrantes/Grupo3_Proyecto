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
            this.lblTipoEleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoEleccion.Location = new System.Drawing.Point(54, 31);
            this.lblTipoEleccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoEleccion.Name = "lblTipoEleccion";
            this.lblTipoEleccion.Size = new System.Drawing.Size(123, 20);
            this.lblTipoEleccion.TabIndex = 0;
            this.lblTipoEleccion.Text = "Tipo de eleccion";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(369, 31);
            this.lblTiempo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(61, 20);
            this.lblTiempo.TabIndex = 1;
            this.lblTiempo.Text = "Tiempo";
            // 
            // dgvCandidatos
            // 
            this.dgvCandidatos.AllowUserToAddRows = false;
            this.dgvCandidatos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidatos.Location = new System.Drawing.Point(58, 73);
            this.dgvCandidatos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCandidatos.MultiSelect = false;
            this.dgvCandidatos.Name = "dgvCandidatos";
            this.dgvCandidatos.ReadOnly = true;
            this.dgvCandidatos.RowHeadersWidth = 51;
            this.dgvCandidatos.RowTemplate.Height = 24;
            this.dgvCandidatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCandidatos.Size = new System.Drawing.Size(564, 241);
            this.dgvCandidatos.TabIndex = 2;
            this.dgvCandidatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCandidatos_CellContentClick);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(497, 336);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(125, 38);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // frmVotacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(678, 397);
            this.ControlBox = false;
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.dgvCandidatos);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblTipoEleccion);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVotacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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