namespace grupo3_Proyecto
{
    partial class frmAdministrarPadron
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
            this.Salir = new System.Windows.Forms.Label();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.lblModificar = new System.Windows.Forms.Label();
            this.lblCrear = new System.Windows.Forms.Label();
            this.btnAtrás = new System.Windows.Forms.Button();
            this.txtAdministrarPadron = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Salir
            // 
            this.Salir.AutoSize = true;
            this.Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.Location = new System.Drawing.Point(380, 344);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(55, 25);
            this.Salir.TabIndex = 91;
            this.Salir.Text = "Salir";
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar.Location = new System.Drawing.Point(365, 266);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(89, 25);
            this.lblEliminar.TabIndex = 90;
            this.lblEliminar.Text = "Eliminar";
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificar.Location = new System.Drawing.Point(354, 189);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(100, 25);
            this.lblModificar.TabIndex = 89;
            this.lblModificar.Text = "Modificar";
            // 
            // lblCrear
            // 
            this.lblCrear.AutoSize = true;
            this.lblCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrear.Location = new System.Drawing.Point(365, 95);
            this.lblCrear.Name = "lblCrear";
            this.lblCrear.Size = new System.Drawing.Size(65, 25);
            this.lblCrear.TabIndex = 88;
            this.lblCrear.Text = "Crear";
            // 
            // btnAtrás
            // 
            this.btnAtrás.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtrás.Location = new System.Drawing.Point(658, 391);
            this.btnAtrás.Name = "btnAtrás";
            this.btnAtrás.Size = new System.Drawing.Size(94, 38);
            this.btnAtrás.TabIndex = 87;
            this.btnAtrás.Text = "Atrás";
            this.btnAtrás.UseVisualStyleBackColor = true;
            // 
            // txtAdministrarPadron
            // 
            this.txtAdministrarPadron.AutoSize = true;
            this.txtAdministrarPadron.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdministrarPadron.Location = new System.Drawing.Point(237, 30);
            this.txtAdministrarPadron.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtAdministrarPadron.Name = "txtAdministrarPadron";
            this.txtAdministrarPadron.Size = new System.Drawing.Size(323, 36);
            this.txtAdministrarPadron.TabIndex = 86;
            this.txtAdministrarPadron.Text = "Administrar Padrón";
            // 
            // frmAdministrarPadron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.lblEliminar);
            this.Controls.Add(this.lblModificar);
            this.Controls.Add(this.lblCrear);
            this.Controls.Add(this.btnAtrás);
            this.Controls.Add(this.txtAdministrarPadron);
            this.Name = "frmAdministrarPadron";
            this.Text = "Administrar Padrón";
            this.Load += new System.EventHandler(this.frmAdministrarPadron_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Salir;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.Label lblCrear;
        private System.Windows.Forms.Button btnAtrás;
        private System.Windows.Forms.Label txtAdministrarPadron;
    }
}