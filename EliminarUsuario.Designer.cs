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
            this.btnAtrásEliminar.Location = new System.Drawing.Point(572, 428);
            this.btnAtrásEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAtrásEliminar.Name = "btnAtrásEliminar";
            this.btnAtrásEliminar.Size = new System.Drawing.Size(161, 55);
            this.btnAtrásEliminar.TabIndex = 118;
            this.btnAtrásEliminar.Text = "Atrás";
            this.btnAtrásEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.Location = new System.Drawing.Point(328, 428);
            this.btnEliminarUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(161, 55);
            this.btnEliminarUsuario.TabIndex = 117;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // lblUsuarioEliminado
            // 
            this.lblUsuarioEliminado.AutoSize = true;
            this.lblUsuarioEliminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioEliminado.Location = new System.Drawing.Point(152, 251);
            this.lblUsuarioEliminado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuarioEliminado.Name = "lblUsuarioEliminado";
            this.lblUsuarioEliminado.Size = new System.Drawing.Size(234, 31);
            this.lblUsuarioEliminado.TabIndex = 115;
            this.lblUsuarioEliminado.Text = "Ingrese el Usuario";
            // 
            // txtUsuarioEliminado
            // 
            this.txtUsuarioEliminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioEliminado.Location = new System.Drawing.Point(415, 252);
            this.txtUsuarioEliminado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuarioEliminado.Name = "txtUsuarioEliminado";
            this.txtUsuarioEliminado.Size = new System.Drawing.Size(581, 30);
            this.txtUsuarioEliminado.TabIndex = 114;
            // 
            // txtCrearUsuario
            // 
            this.txtCrearUsuario.AutoSize = true;
            this.txtCrearUsuario.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrearUsuario.Location = new System.Drawing.Point(341, 63);
            this.txtCrearUsuario.Name = "txtCrearUsuario";
            this.txtCrearUsuario.Size = new System.Drawing.Size(354, 45);
            this.txtCrearUsuario.TabIndex = 113;
            this.txtCrearUsuario.Text = "Eliminar Usuario";
            // 
            // pctUsuario
            // 
            this.pctUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pctUsuario.Image")));
            this.pctUsuario.Location = new System.Drawing.Point(71, 233);
            this.pctUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pctUsuario.Name = "pctUsuario";
            this.pctUsuario.Size = new System.Drawing.Size(61, 62);
            this.pctUsuario.TabIndex = 116;
            this.pctUsuario.TabStop = false;
            // 
            // EliminarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnAtrásEliminar);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.pctUsuario);
            this.Controls.Add(this.lblUsuarioEliminado);
            this.Controls.Add(this.txtUsuarioEliminado);
            this.Controls.Add(this.txtCrearUsuario);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EliminarUsuario";
            this.Text = "EliminarUsuario";
            this.Load += new System.EventHandler(this.EliminarUsuario_Load);
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