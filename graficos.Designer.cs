namespace grupo3_Proyecto
{
    partial class frmGraficos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend17 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend18 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea19 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend19 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea20 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend20 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.chartVotosCandidatos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartVotosPartidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartParticipacionProvincia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTipoEleccion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvResumen = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnExportarPDF = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartVotosCandidatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVotosPartidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartParticipacionProvincia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTipoEleccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lbltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.Location = new System.Drawing.Point(0, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(460, 25);
            this.lbltitulo.TabIndex = 6;
            this.lbltitulo.Text = "Sistema Electoral - Graficos y Estadisticas";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartVotosCandidatos
            // 
            this.chartVotosCandidatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea17.Name = "ChartArea1";
            this.chartVotosCandidatos.ChartAreas.Add(chartArea17);
            legend17.Name = "Legend1";
            this.chartVotosCandidatos.Legends.Add(legend17);
            this.chartVotosCandidatos.Location = new System.Drawing.Point(12, 41);
            this.chartVotosCandidatos.Name = "chartVotosCandidatos";
            series17.ChartArea = "ChartArea1";
            series17.Legend = "Legend1";
            series17.Name = "Series1";
            this.chartVotosCandidatos.Series.Add(series17);
            this.chartVotosCandidatos.Size = new System.Drawing.Size(410, 142);
            this.chartVotosCandidatos.TabIndex = 7;
            this.chartVotosCandidatos.Text = "Votos por Candidato";
            this.chartVotosCandidatos.Click += new System.EventHandler(this.chartVotosCandidatos_Click);
            // 
            // chartVotosPartidos
            // 
            this.chartVotosPartidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea18.Name = "ChartArea1";
            this.chartVotosPartidos.ChartAreas.Add(chartArea18);
            legend18.Name = "Legend1";
            this.chartVotosPartidos.Legends.Add(legend18);
            this.chartVotosPartidos.Location = new System.Drawing.Point(464, 41);
            this.chartVotosPartidos.Name = "chartVotosPartidos";
            series18.ChartArea = "ChartArea1";
            series18.Legend = "Legend1";
            series18.Name = "Series1";
            this.chartVotosPartidos.Series.Add(series18);
            this.chartVotosPartidos.Size = new System.Drawing.Size(334, 142);
            this.chartVotosPartidos.TabIndex = 8;
            this.chartVotosPartidos.Text = "Distribuccion de Votos por Partido";
            this.chartVotosPartidos.Click += new System.EventHandler(this.chartVotosPartidos_Click);
            // 
            // chartParticipacionProvincia
            // 
            this.chartParticipacionProvincia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea19.Name = "ChartArea1";
            this.chartParticipacionProvincia.ChartAreas.Add(chartArea19);
            legend19.Name = "Legend1";
            this.chartParticipacionProvincia.Legends.Add(legend19);
            this.chartParticipacionProvincia.Location = new System.Drawing.Point(12, 189);
            this.chartParticipacionProvincia.Name = "chartParticipacionProvincia";
            series19.ChartArea = "ChartArea1";
            series19.Legend = "Legend1";
            series19.Name = "Series1";
            this.chartParticipacionProvincia.Series.Add(series19);
            this.chartParticipacionProvincia.Size = new System.Drawing.Size(410, 137);
            this.chartParticipacionProvincia.TabIndex = 9;
            this.chartParticipacionProvincia.Text = "Participacion Electoral por Provincia";
            this.chartParticipacionProvincia.Click += new System.EventHandler(this.chartParticipacionProvincia_Click);
            // 
            // chartTipoEleccion
            // 
            this.chartTipoEleccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            chartArea20.Name = "ChartArea1";
            this.chartTipoEleccion.ChartAreas.Add(chartArea20);
            legend20.Name = "Legend1";
            this.chartTipoEleccion.Legends.Add(legend20);
            this.chartTipoEleccion.Location = new System.Drawing.Point(464, 189);
            this.chartTipoEleccion.Name = "chartTipoEleccion";
            series20.ChartArea = "ChartArea1";
            series20.Legend = "Legend1";
            series20.Name = "Series1";
            this.chartTipoEleccion.Series.Add(series20);
            this.chartTipoEleccion.Size = new System.Drawing.Size(334, 137);
            this.chartTipoEleccion.TabIndex = 10;
            this.chartTipoEleccion.Text = "Votos por Tipo de Eleccion";
            this.chartTipoEleccion.Click += new System.EventHandler(this.chartTipoEleccion_Click);
            // 
            // dgvResumen
            // 
            this.dgvResumen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResumen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResumen.BackgroundColor = System.Drawing.Color.White;
            this.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumen.Location = new System.Drawing.Point(46, 359);
            this.dgvResumen.Name = "dgvResumen";
            this.dgvResumen.ReadOnly = true;
            this.dgvResumen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResumen.Size = new System.Drawing.Size(376, 159);
            this.dgvResumen.TabIndex = 11;
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(442, 474);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(92, 44);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnExportarPDF
            // 
            this.btnExportarPDF.AutoSize = true;
            this.btnExportarPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnExportarPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarPDF.ForeColor = System.Drawing.Color.White;
            this.btnExportarPDF.Location = new System.Drawing.Point(540, 474);
            this.btnExportarPDF.Name = "btnExportarPDF";
            this.btnExportarPDF.Size = new System.Drawing.Size(92, 44);
            this.btnExportarPDF.TabIndex = 13;
            this.btnExportarPDF.Text = "Exportar PDF";
            this.btnExportarPDF.UseVisualStyleBackColor = false;
            this.btnExportarPDF.Click += new System.EventHandler(this.btnExportarPDF_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.BackColor = System.Drawing.Color.Gray;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(638, 474);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(92, 44);
            this.btnImprimir.TabIndex = 14;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // frmGraficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(848, 530);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnExportarPDF);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvResumen);
            this.Controls.Add(this.chartTipoEleccion);
            this.Controls.Add(this.chartParticipacionProvincia);
            this.Controls.Add(this.chartVotosPartidos);
            this.Controls.Add(this.chartVotosCandidatos);
            this.Controls.Add(this.lbltitulo);
            this.Name = "frmGraficos";
            this.Text = "Graficos del Sistema";
            this.Load += new System.EventHandler(this.frmGraficos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartVotosCandidatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVotosPartidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartParticipacionProvincia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTipoEleccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVotosCandidatos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVotosPartidos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartParticipacionProvincia;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTipoEleccion;
        private System.Windows.Forms.DataGridView dgvResumen;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnExportarPDF;
        private System.Windows.Forms.Button btnImprimir;
    }
}