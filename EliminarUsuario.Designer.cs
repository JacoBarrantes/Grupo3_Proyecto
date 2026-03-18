namespace grupo3_Proyecto
{
    partial class EliminarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarUsuario));
            this.btnAtrásEliminar = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.lblUsuarioEliminado = new System.Windows.Forms.Label();
            this.txtUsuarioEliminado = new System.Windows.Forms.TextBox();
            this.txtCrearUsuario = new System.Windows.Forms.Label();
            this.pctUsuario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtrásEliminar
            // 
            this.btnAtrásEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtrásEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtrásEliminar.Location = new System.Drawing.Point(429, 348);
            this.btnAtrásEliminar.Name = "btnAtrásEliminar";
            this.btnAtrásEliminar.Size = new System.Drawing.Size(121, 45);
            this.btnAtrásEliminar.TabIndex = 118;
            this.btnAtrásEliminar.Text = "Atrás";
            this.btnAtrásEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.Location = new System.Drawing.Point(246, 348);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(121, 45);
            this.btnEliminarUsuario.TabIndex = 117;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            // 
            // lblUsuarioEliminado
            // 
            this.lblUsuarioEliminado.AutoSize = true;
            this.lblUsuarioEliminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioEliminado.Location = new System.Drawing.Point(114, 204);
            this.lblUsuarioEliminado.Name = "lblUsuarioEliminado";
            this.lblUsuarioEliminado.Size = new System.Drawing.Size(186, 25);
            this.lblUsuarioEliminado.TabIndex = 115;
            this.lblUsuarioEliminado.Text = "Ingrese el Usuario";
            // 
            // txtUsuarioEliminado
            // 
            this.txtUsuarioEliminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioEliminado.Location = new System.Drawing.Point(311, 205);
            this.txtUsuarioEliminado.Name = "txtUsuarioEliminado";
            this.txtUsuarioEliminado.Size = new System.Drawing.Size(437, 26);
            this.txtUsuarioEliminado.TabIndex = 114;
            // 
            // txtCrearUsuario
            // 
            this.txtCrearUsuario.AutoSize = true;
            this.txtCrearUsuario.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrearUsuario.Location = new System.Drawing.Point(256, 51);
            this.txtCrearUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtCrearUsuario.Name = "txtCrearUsuario";
            this.txtCrearUsuario.Size = new System.Drawing.Size(285, 36);
            this.txtCrearUsuario.TabIndex = 113;
            this.txtCrearUsuario.Text = "Eliminar Usuario";
            // 
            // pctUsuario
            // 
            this.pctUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pctUsuario.Image")));
            this.pctUsuario.Location = new System.Drawing.Point(53, 189);
            this.pctUsuario.Name = "pctUsuario";
            this.pctUsuario.Size = new System.Drawing.Size(46, 50);
            this.pctUsuario.TabIndex = 116;
            this.pctUsuario.TabStop = false;
            // 
            // EliminarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtrásEliminar);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.pctUsuario);
            this.Controls.Add(this.lblUsuarioEliminado);
            this.Controls.Add(this.txtUsuarioEliminado);
            this.Controls.Add(this.txtCrearUsuario);
            this.Name = "EliminarUsuario";
            this.Text = "EliminarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtrásEliminar;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.PictureBox pctUsuario;
        private System.Windows.Forms.Label lblUsuarioEliminado;
        private System.Windows.Forms.TextBox txtUsuarioEliminado;
        private System.Windows.Forms.Label txtCrearUsuario;
    }
}