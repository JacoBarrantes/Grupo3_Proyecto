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
            this.Salir.Location = new System.Drawing.Point(507, 423);
            this.Salir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(68, 31);
            this.Salir.TabIndex = 91;
            this.Salir.Text = "Salir";
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar.Location = new System.Drawing.Point(487, 327);
            this.lblEliminar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(111, 31);
            this.lblEliminar.TabIndex = 90;
            this.lblEliminar.Text = "Eliminar";
            // 
            // lblModificar
            // 
            this.lblModificar.AutoSize = true;
            this.lblModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificar.Location = new System.Drawing.Point(472, 233);
            this.lblModificar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(124, 31);
            this.lblModificar.TabIndex = 89;
            this.lblModificar.Text = "Modificar";
            // 
            // lblCrear
            // 
            this.lblCrear.AutoSize = true;
            this.lblCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrear.Location = new System.Drawing.Point(487, 117);
            this.lblCrear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCrear.Name = "lblCrear";
            this.lblCrear.Size = new System.Drawing.Size(82, 31);
            this.lblCrear.TabIndex = 88;
            this.lblCrear.Text = "Crear";
            // 
            // btnAtrás
            // 
            this.btnAtrás.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtrás.Location = new System.Drawing.Point(877, 481);
            this.btnAtrás.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAtrás.Name = "btnAtrás";
            this.btnAtrás.Size = new System.Drawing.Size(125, 47);
            this.btnAtrás.TabIndex = 87;
            this.btnAtrás.Text = "Atrás";
            this.btnAtrás.UseVisualStyleBackColor = true;
            // 
            // txtAdministrarPadron
            // 
            this.txtAdministrarPadron.AutoSize = true;
            this.txtAdministrarPadron.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdministrarPadron.Location = new System.Drawing.Point(316, 37);
            this.txtAdministrarPadron.Name = "txtAdministrarPadron";
            this.txtAdministrarPadron.Size = new System.Drawing.Size(400, 45);
            this.txtAdministrarPadron.TabIndex = 86;
            this.txtAdministrarPadron.Text = "Administrar Padrón";
            // 
            // frmAdministrarPadron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.lblEliminar);
            this.Controls.Add(this.lblModificar);
            this.Controls.Add(this.lblCrear);
            this.Controls.Add(this.btnAtrás);
            this.Controls.Add(this.txtAdministrarPadron);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAdministrarPadron";
            this.Text = "Administrar Padrón";
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