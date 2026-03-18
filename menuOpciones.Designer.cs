namespace grupo3_Proyecto
{
    partial class frmMenuOpciones
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
            this.txtMenu = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblCredenciales = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lblReportes = new System.Windows.Forms.Label();
            this.lblPadron = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMenu
            // 
            this.txtMenu.AutoSize = true;
            this.txtMenu.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenu.Location = new System.Drawing.Point(255, 27);
            this.txtMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtMenu.Name = "txtMenu";
            this.txtMenu.Size = new System.Drawing.Size(280, 36);
            this.txtMenu.TabIndex = 80;
            this.txtMenu.Text = "Menú de opciones";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(662, 386);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 38);
            this.btnSalir.TabIndex = 81;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblCredenciales
            // 
            this.lblCredenciales.AutoSize = true;
            this.lblCredenciales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredenciales.Location = new System.Drawing.Point(327, 114);
            this.lblCredenciales.Name = "lblCredenciales";
            this.lblCredenciales.Size = new System.Drawing.Size(138, 25);
            this.lblCredenciales.TabIndex = 82;
            this.lblCredenciales.Text = "Credenciales";
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(286, 180);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(233, 25);
            this.lblRegistro.TabIndex = 83;
            this.lblRegistro.Text = "Registro de candidatos";
            this.lblRegistro.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblReportes
            // 
            this.lblReportes.AutoSize = true;
            this.lblReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportes.Location = new System.Drawing.Point(350, 259);
            this.lblReportes.Name = "lblReportes";
            this.lblReportes.Size = new System.Drawing.Size(99, 25);
            this.lblReportes.TabIndex = 84;
            this.lblReportes.Text = "Reportes";
            this.lblReportes.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPadron
            // 
            this.lblPadron.AutoSize = true;
            this.lblPadron.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPadron.Location = new System.Drawing.Point(309, 336);
            this.lblPadron.Name = "lblPadron";
            this.lblPadron.Size = new System.Drawing.Size(195, 25);
            this.lblPadron.TabIndex = 85;
            this.lblPadron.Text = "Administrar Padron";
            // 
            // frmMenuOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPadron);
            this.Controls.Add(this.lblReportes);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.lblCredenciales);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtMenu);
            this.Name = "frmMenuOpciones";
            this.Text = "Menú de opciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtMenu;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblCredenciales;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label lblReportes;
        private System.Windows.Forms.Label lblPadron;
    }
}