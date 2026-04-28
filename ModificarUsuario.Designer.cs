namespace grupo3_Proyecto
{
    partial class ModificarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarUsuario));
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.lblNumeroCedula = new System.Windows.Forms.Label();
            this.txtNumeroCedula = new System.Windows.Forms.TextBox();
            this.txtModificarUsuario = new System.Windows.Forms.Label();
            this.pctUsuario = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.btnSalirAlMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarUsuario.Location = new System.Drawing.Point(54, 348);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(121, 45);
            this.btnModificarUsuario.TabIndex = 117;
            this.btnModificarUsuario.Text = "Modificar";
            this.btnModificarUsuario.UseVisualStyleBackColor = false;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // lblNumeroCedula
            // 
            this.lblNumeroCedula.AutoSize = true;
            this.lblNumeroCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCedula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNumeroCedula.Location = new System.Drawing.Point(116, 159);
            this.lblNumeroCedula.Name = "lblNumeroCedula";
            this.lblNumeroCedula.Size = new System.Drawing.Size(191, 25);
            this.lblNumeroCedula.TabIndex = 115;
            this.lblNumeroCedula.Text = "Numero de Cedula";
            // 
            // txtNumeroCedula
            // 
            this.txtNumeroCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCedula.Location = new System.Drawing.Point(343, 160);
            this.txtNumeroCedula.Name = "txtNumeroCedula";
            this.txtNumeroCedula.Size = new System.Drawing.Size(330, 26);
            this.txtNumeroCedula.TabIndex = 114;
            this.txtNumeroCedula.TextChanged += new System.EventHandler(this.txtNumeroCedula_TextChanged);
            // 
            // txtModificarUsuario
            // 
            this.txtModificarUsuario.AutoSize = true;
            this.txtModificarUsuario.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModificarUsuario.Location = new System.Drawing.Point(194, 46);
            this.txtModificarUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtModificarUsuario.Name = "txtModificarUsuario";
            this.txtModificarUsuario.Size = new System.Drawing.Size(294, 36);
            this.txtModificarUsuario.TabIndex = 113;
            this.txtModificarUsuario.Text = "Modificar Usuario";
            // 
            // pctUsuario
            // 
            this.pctUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pctUsuario.Image")));
            this.pctUsuario.Location = new System.Drawing.Point(54, 144);
            this.pctUsuario.Name = "pctUsuario";
            this.pctUsuario.Size = new System.Drawing.Size(46, 50);
            this.pctUsuario.TabIndex = 116;
            this.pctUsuario.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 230);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 50);
            this.pictureBox1.TabIndex = 121;
            this.pictureBox1.TabStop = false;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRol.Location = new System.Drawing.Point(116, 245);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(159, 25);
            this.lblRol.TabIndex = 120;
            this.lblRol.Text = "Rol del Usuario";
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Location = new System.Drawing.Point(343, 251);
            this.cmbPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(330, 28);
            this.cmbPerfil.TabIndex = 122;
            this.cmbPerfil.SelectedIndexChanged += new System.EventHandler(this.cmbPerfil_SelectedIndexChanged);
            this.cmbPerfil.SelectionChangeCommitted += new System.EventHandler(this.cmbPerfil_SelectionChangeCommitted);
            // 
            // btnSalirAlMenu
            // 
            this.btnSalirAlMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSalirAlMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirAlMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirAlMenu.Location = new System.Drawing.Point(552, 348);
            this.btnSalirAlMenu.Name = "btnSalirAlMenu";
            this.btnSalirAlMenu.Size = new System.Drawing.Size(121, 45);
            this.btnSalirAlMenu.TabIndex = 123;
            this.btnSalirAlMenu.Text = "Salir";
            this.btnSalirAlMenu.UseVisualStyleBackColor = false;
            this.btnSalirAlMenu.Click += new System.EventHandler(this.btnSalirAlMenu_Click);
            // 
            // ModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.btnSalirAlMenu);
            this.Controls.Add(this.cmbPerfil);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.btnModificarUsuario);
            this.Controls.Add(this.pctUsuario);
            this.Controls.Add(this.lblNumeroCedula);
            this.Controls.Add(this.txtNumeroCedula);
            this.Controls.Add(this.txtModificarUsuario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarUsuario";
            this.Load += new System.EventHandler(this.ModificarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.PictureBox pctUsuario;
        private System.Windows.Forms.Label lblNumeroCedula;
        private System.Windows.Forms.TextBox txtNumeroCedula;
        private System.Windows.Forms.Label txtModificarUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private System.Windows.Forms.Button btnSalirAlMenu;
    }
}