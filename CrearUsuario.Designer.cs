namespace grupo3_Proyecto
{
    partial class frmCrearUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrearUsuario));
            this.btnAtrásUsuario = new System.Windows.Forms.Button();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.pctUsuario = new System.Windows.Forms.PictureBox();
            this.lblNuevoUsuario = new System.Windows.Forms.Label();
            this.txtNuevoUsuario = new System.Windows.Forms.TextBox();
            this.txtCrearUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtrásUsuario
            // 
            this.btnAtrásUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtrásUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtrásUsuario.Location = new System.Drawing.Point(429, 348);
            this.btnAtrásUsuario.Name = "btnAtrásUsuario";
            this.btnAtrásUsuario.Size = new System.Drawing.Size(121, 45);
            this.btnAtrásUsuario.TabIndex = 112;
            this.btnAtrásUsuario.Text = "Atrás";
            this.btnAtrásUsuario.UseVisualStyleBackColor = true;
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearUsuario.Location = new System.Drawing.Point(246, 348);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(121, 45);
            this.btnCrearUsuario.TabIndex = 111;
            this.btnCrearUsuario.Text = "Crear";
            this.btnCrearUsuario.UseVisualStyleBackColor = false;
            // 
            // pctUsuario
            // 
            this.pctUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pctUsuario.Image")));
            this.pctUsuario.Location = new System.Drawing.Point(53, 189);
            this.pctUsuario.Name = "pctUsuario";
            this.pctUsuario.Size = new System.Drawing.Size(46, 50);
            this.pctUsuario.TabIndex = 110;
            this.pctUsuario.TabStop = false;
            // 
            // lblNuevoUsuario
            // 
            this.lblNuevoUsuario.AutoSize = true;
            this.lblNuevoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoUsuario.Location = new System.Drawing.Point(118, 204);
            this.lblNuevoUsuario.Name = "lblNuevoUsuario";
            this.lblNuevoUsuario.Size = new System.Drawing.Size(154, 25);
            this.lblNuevoUsuario.TabIndex = 109;
            this.lblNuevoUsuario.Text = "Nuevo Usuario";
            // 
            // txtNuevoUsuario
            // 
            this.txtNuevoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevoUsuario.Location = new System.Drawing.Point(295, 205);
            this.txtNuevoUsuario.Name = "txtNuevoUsuario";
            this.txtNuevoUsuario.Size = new System.Drawing.Size(453, 26);
            this.txtNuevoUsuario.TabIndex = 108;
            // 
            // txtCrearUsuario
            // 
            this.txtCrearUsuario.AutoSize = true;
            this.txtCrearUsuario.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrearUsuario.Location = new System.Drawing.Point(272, 58);
            this.txtCrearUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtCrearUsuario.Name = "txtCrearUsuario";
            this.txtCrearUsuario.Size = new System.Drawing.Size(226, 36);
            this.txtCrearUsuario.TabIndex = 107;
            this.txtCrearUsuario.Text = "Crear Usuario";
            // 
            // frmCrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtrásUsuario);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.pctUsuario);
            this.Controls.Add(this.lblNuevoUsuario);
            this.Controls.Add(this.txtNuevoUsuario);
            this.Controls.Add(this.txtCrearUsuario);
            this.Name = "frmCrearUsuario";
            this.Text = "Crear Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtrásUsuario;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.PictureBox pctUsuario;
        private System.Windows.Forms.Label lblNuevoUsuario;
        private System.Windows.Forms.TextBox txtNuevoUsuario;
        private System.Windows.Forms.Label txtCrearUsuario;
    }
}