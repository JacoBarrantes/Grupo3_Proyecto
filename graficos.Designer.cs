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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.chartVotosCandidatos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartVotosPartidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartParticipacionProvincia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTipoEleccion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvResumen = new System.Windows.Forms.DataGridView();
            this.Candidato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Partido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalVotos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            chartArea1.Name = "ChartArea1";
            this.chartVotosCandidatos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartVotosCandidatos.Legends.Add(legend1);
            this.chartVotosCandidatos.Location = new System.Drawing.Point(12, 41);
            this.chartVotosCandidatos.Name = "chartVotosCandidatos";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartVotosCandidatos.Series.Add(series1);
            this.chartVotosCandidatos.Size = new System.Drawing.Size(410, 142);
            this.chartVotosCandidatos.TabIndex = 7;
            this.chartVotosCandidatos.Text = "Votos por Candidato";
            this.chartVotosCandidatos.Click += new System.EventHandler(this.chartVotosCandidatos_Click);
            // 
            // chartVotosPartidos
            // 
            this.chartVotosPartidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartVotosPartidos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartVotosPartidos.Legends.Add(legend2);
            this.chartVotosPartidos.Location = new System.Drawing.Point(464, 41);
            this.chartVotosPartidos.Name = "chartVotosPartidos";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartVotosPartidos.Series.Add(series2);
            this.chartVotosPartidos.Size = new System.Drawing.Size(334, 142);
            this.chartVotosPartidos.TabIndex = 8;
            this.chartVotosPartidos.Text = "Distribuccion de Votos por Partido";
            this.chartVotosPartidos.Click += new System.EventHandler(this.chartVotosPartidos_Click);
            // 
            // chartParticipacionProvincia
            // 
            this.chartParticipacionProvincia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chartParticipacionProvincia.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartParticipacionProvincia.Legends.Add(legend3);
            this.chartParticipacionProvincia.Location = new System.Drawing.Point(12, 189);
            this.chartParticipacionProvincia.Name = "chartParticipacionProvincia";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartParticipacionProvincia.Series.Add(series3);
            this.chartParticipacionProvincia.Size = new System.Drawing.Size(410, 137);
            this.chartParticipacionProvincia.TabIndex = 9;
            this.chartParticipacionProvincia.Text = "Participacion Electoral por Provincia";
            this.chartParticipacionProvincia.Click += new System.EventHandler(this.chartParticipacionProvincia_Click);
            // 
            // chartTipoEleccion
            // 
            this.chartTipoEleccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.chartTipoEleccion.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartTipoEleccion.Legends.Add(legend4);
            this.chartTipoEleccion.Location = new System.Drawing.Point(464, 189);
            this.chartTipoEleccion.Name = "chartTipoEleccion";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartTipoEleccion.Series.Add(series4);
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
            this.dgvResumen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Candidato,
            this.Partido,
            this.TotalVotos,
            this.Porcentaje});
            this.dgvResumen.Location = new System.Drawing.Point(46, 359);
            this.dgvResumen.Name = "dgvResumen";
            this.dgvResumen.ReadOnly = true;
            this.dgvResumen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResumen.Size = new System.Drawing.Size(376, 159);
            this.dgvResumen.TabIndex = 11;
            // 
            // Candidato
            // 
            this.Candidato.HeaderText = "Candidato";
            this.Candidato.Name = "Candidato";
            this.Candidato.ReadOnly = true;
            // 
            // Partido
            // 
            this.Partido.HeaderText = "Partido";
            this.Partido.Name = "Partido";
            this.Partido.ReadOnly = true;
            // 
            // TotalVotos
            // 
            this.TotalVotos.HeaderText = "Total Votos";
            this.TotalVotos.Name = "TotalVotos";
            this.TotalVotos.ReadOnly = true;
            // 
            // Porcentaje
            // 
            this.Porcentaje.HeaderText = "Porcentaje";
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.ReadOnly = true;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Candidato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partido;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalVotos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnExportarPDF;
        private System.Windows.Forms.Button btnImprimir;
    }
}