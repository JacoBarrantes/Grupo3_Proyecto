namespace grupo3_Proyecto
{
    partial class EleccionPresidencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EleccionPresidencia));
            this.txtElecciones = new System.Windows.Forms.Label();
            this.txtPresidencia = new System.Windows.Forms.Label();
            this.pctTSE = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctTSE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtElecciones
            // 
            this.txtElecciones.AutoSize = true;
            this.txtElecciones.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElecciones.Location = new System.Drawing.Point(278, 12);
            this.txtElecciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtElecciones.Name = "txtElecciones";
            this.txtElecciones.Size = new System.Drawing.Size(264, 47);
            this.txtElecciones.TabIndex = 0;
            this.txtElecciones.Text = "Elecciones 2026";
            // 
            // txtPresidencia
            // 
            this.txtPresidencia.AutoSize = true;
            this.txtPresidencia.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresidencia.Location = new System.Drawing.Point(248, 59);
            this.txtPresidencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtPresidencia.Name = "txtPresidencia";
            this.txtPresidencia.Size = new System.Drawing.Size(332, 57);
            this.txtPresidencia.TabIndex = 1;
            this.txtPresidencia.Text = "Presidencia";
            // 
            // pctTSE
            // 
            this.pctTSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctTSE.ErrorImage = null;
            this.pctTSE.Image = ((System.Drawing.Image)(resources.GetObject("pctTSE.Image")));
            this.pctTSE.InitialImage = null;
            this.pctTSE.Location = new System.Drawing.Point(603, 12);
            this.pctTSE.Name = "pctTSE";
            this.pctTSE.Size = new System.Drawing.Size(168, 149);
            this.pctTSE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctTSE.TabIndex = 2;
            this.pctTSE.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(26, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // EleccionPresidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(843, 736);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pctTSE);
            this.Controls.Add(this.txtPresidencia);
            this.Controls.Add(this.txtElecciones);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EleccionPresidencia";
            this.Text = "EleccionPresidencia";
            ((System.ComponentModel.ISupportInitialize)(this.pctTSE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtElecciones;
        private System.Windows.Forms.Label txtPresidencia;
        private System.Windows.Forms.PictureBox pctTSE;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}