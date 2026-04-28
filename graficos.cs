using MyLibreriaVoto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;





namespace grupo3_Proyecto
{
    public partial class frmGraficos : Form
    {
        public frmGraficos()
        {
            InitializeComponent();
        }

        private void frmGraficos_Load(object sender, EventArgs e)
        {
            CargarGraficVotosCandidatos();
            GraficoVotosPorPartido();
            GraficoParticipacionPorProvincia();
            GraficoTipoEleccion();
            CargarDataGridViewResumen();
        }

        private void chartVotosCandidatos_Click(object sender, EventArgs e)
        {
            CargarGraficVotosCandidatos();
        }
        public void CargarGraficVotosCandidatos()
        {

            string query = @"
                SELECT 
                    c.Nombre + ' ' + c.Apellidos AS Candidato,
                    COUNT(v.IdVoto) AS TotalVotos
                FROM Candidatos c
                LEFT JOIN Votacion v ON c.IdCandidato = v.IdCandidato
                GROUP BY c.IdCandidato, c.Nombre, c.Apellidos
                ORDER BY TotalVotos DESC";

            
            DataSet ds = Utilidades.ejecutar(query);
            DataTable dt = ds.Tables[0];

            chartVotosCandidatos.Titles.Clear();
            chartVotosCandidatos.Titles.Add("Votos por Candidato");
            chartVotosCandidatos.Series.Clear();

            Series series = new Series("Votos");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;
            series.LabelFormat = "N0";

            foreach (DataRow row in dt.Rows)
            {
                series.Points.AddXY(row["Candidato"].ToString(), row["TotalVotos"]);
            }

            chartVotosCandidatos.Series.Add(series);
            chartVotosCandidatos.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

        }

        
        private void CargarGraficoConFiltro(int idPartido)
        {
            string query = @"
                SELECT 
                    c.Nombre + ' ' + c.Apellidos AS Candidato,
                    COUNT(v.IdVoto) AS TotalVotos
                FROM Candidatos c
                LEFT JOIN Votacion v ON c.IdCandidato = v.IdCandidato
                WHERE c.IdPartido = @IdPartido
                GROUP BY c.IdCandidato, c.Nombre, c.Apellidos
                ORDER BY TotalVotos DESC";

           
            DataSet ds = Utilidades.ejecutar(query,
                new SqlParameter("@IdPartido", idPartido));

            DataTable dt = ds.Tables[0];
            
        }

        private void chartVotosPartidos_Click(object sender, EventArgs e)
        {
            GraficoVotosPorPartido();
        }
        public void GraficoVotosPorPartido()
        {
            string query = @"
                SELECT 
                    pp.NombrePartido,
                    COUNT(v.IdVoto) AS TotalVotos
                FROM PartidosPoliticos pp
                LEFT JOIN Candidatos c ON pp.IdPartido = c.IdPartido
                LEFT JOIN Votacion v ON c.IdCandidato = v.IdCandidato
                GROUP BY pp.IdPartido, pp.NombrePartido
                ORDER BY TotalVotos DESC";

            DataSet ds = Utilidades.ejecutar(query);
            DataTable dt = ds.Tables[0];

            chartVotosPartidos.Titles.Clear();
            chartVotosPartidos.Titles.Add("Distribución de Votos por Partido");
            chartVotosPartidos.Series.Clear();

            Series series = new Series("Partidos");
            series.ChartType = SeriesChartType.Pie;
            series.IsValueShownAsLabel = true;
            series.LabelFormat = "#,##0 votos";

            string[] colores = { "#FF6384", "#36A2EB", "#FFCE56", "#4BC0C0", "#9966FF", "#FF9F40" };
            int colorIndex = 0;

            foreach (DataRow row in dt.Rows)
            {
                DataPoint point = new DataPoint();
                point.AxisLabel = row["NombrePartido"].ToString();
                point.YValues = new double[] { Convert.ToDouble(row["TotalVotos"]) };
                point.Color = ColorTranslator.FromHtml(colores[colorIndex % colores.Length]);
                series.Points.Add(point);
                colorIndex++;
            }

            chartVotosPartidos.Series.Add(series);
        }

        private void chartParticipacionProvincia_Click(object sender, EventArgs e)
        {
            GraficoParticipacionPorProvincia();
        }
        public void GraficoParticipacionPorProvincia()
        {
            string query = @"
                SELECT 
                    d.Provincia,
                    COUNT(DISTINCT pn.Cedula) AS TotalVotantes,
                    SUM(CASE WHEN v.IdVoto IS NOT NULL THEN 1 ELSE 0 END) AS Votaron
                FROM PadronNacional pn
                INNER JOIN DistritoElectoral d ON pn.CodigoElectoral = d.CodigoElectoral
                LEFT JOIN Votacion v ON pn.Cedula = v.Cedula
                GROUP BY d.Provincia
                ORDER BY d.Provincia";

            DataSet ds = Utilidades.ejecutar(query);
            DataTable dt = ds.Tables[0];

            chartParticipacionProvincia.Titles.Clear();
            chartParticipacionProvincia.Titles.Add("Participación Electoral por Provincia");
            chartParticipacionProvincia.Series.Clear();

            Series seriesRegistrados = new Series("Registrados");
            seriesRegistrados.ChartType = SeriesChartType.StackedColumn;
            seriesRegistrados.Color = Color.LightBlue;

            Series seriesVotaron = new Series("Votaron");
            seriesVotaron.ChartType = SeriesChartType.StackedColumn;
            seriesVotaron.Color = Color.DarkBlue;
            seriesVotaron.IsValueShownAsLabel = true;

            foreach (DataRow row in dt.Rows)
            {
                string provincia = row["Provincia"].ToString();
                seriesRegistrados.Points.AddXY(provincia, row["TotalVotantes"]);
                seriesVotaron.Points.AddXY(provincia, row["Votaron"]);
            }

            chartParticipacionProvincia.Series.Add(seriesRegistrados);
            chartParticipacionProvincia.Series.Add(seriesVotaron);
        }

        private void chartTipoEleccion_Click(object sender, EventArgs e)
        {
            GraficoTipoEleccion();
        }
        public void GraficoTipoEleccion()
        {
            string query = @"
                SELECT 
                    te.Descripcion,
                    COUNT(v.IdVoto) AS TotalVotos,
                    COUNT(DISTINCT v.Cedula) AS VotantesUnicos
                FROM TipoEleccion te
                LEFT JOIN Votacion v ON te.IdTipoEleccion = v.IdTipoEleccion
                GROUP BY te.IdTipoEleccion, te.Descripcion";

            DataSet ds = Utilidades.ejecutar(query);
            DataTable dt = ds.Tables[0];

            chartTipoEleccion.Titles.Clear();
            chartTipoEleccion.Titles.Add("Votos por Tipo de Elección");
            chartTipoEleccion.Series.Clear();

            Series series = new Series("TiposEleccion");
            series.ChartType = SeriesChartType.Doughnut;
            series.IsValueShownAsLabel = true;

            foreach (DataRow row in dt.Rows)
                series.Points.AddXY(row["Descripcion"], row["TotalVotos"]);

            chartTipoEleccion.Series.Add(series);
        }
        private void CargarDataGridViewResumen()
        {
            string query = @"
                SELECT 
                    c.Nombre + ' ' + c.Apellidos AS Candidato,
                    pp.NombrePartido AS Partido,
                    COUNT(v.IdVoto) AS TotalVotos,
                    CAST(COUNT(v.IdVoto) * 100.0 / 
                        (SELECT COUNT(*) FROM Votacion) AS DECIMAL(5,2)) AS Porcentaje
                FROM Candidatos c
                INNER JOIN PartidosPoliticos pp ON c.IdPartido = pp.IdPartido
                LEFT JOIN Votacion v ON c.IdCandidato = v.IdCandidato
                GROUP BY c.IdCandidato, c.Nombre, c.Apellidos, pp.NombrePartido
                ORDER BY TotalVotos DESC";

            DataSet ds = Utilidades.ejecutar(query);
            DataTable dt = ds.Tables[0];

            dgvResumen.DataSource = dt;
            dgvResumen.Columns["TotalVotos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvResumen.Columns["Porcentaje"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvResumen.Columns["Porcentaje"].DefaultCellStyle.Format = "N2";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizar();
        }
        public void actualizar()
        {
            CargarGraficVotosCandidatos();
            MessageBox.Show("Gráficos actualizados correctamente", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            imprimir();
        }
        public void imprimir()
        {
            
            Bitmap bmpForm = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmpForm, new Rectangle(0, 0, this.Width, this.Height));

            PrintDocument printDocument = new PrintDocument();
            printDocument.DefaultPageSettings.Landscape = true;

            printDocument.PrintPage += (s, ev) =>
            {
                float scaleX = ev.PageBounds.Width / (float)bmpForm.Width;
                float scaleY = ev.PageBounds.Height / (float)bmpForm.Height;
                float scale = Math.Min(scaleX, scaleY);

                int drawWidth = (int)(bmpForm.Width * scale);
                int drawHeight = (int)(bmpForm.Height * scale);
                int drawX = (ev.PageBounds.Width - drawWidth) / 2;
                int drawY = (ev.PageBounds.Height - drawHeight) / 2;

                ev.Graphics.DrawImage(bmpForm,
                    new Rectangle(drawX, drawY, drawWidth, drawHeight));

                bmpForm.Dispose();
            };

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDocument;
            preview.WindowState = FormWindowState.Maximized;
            preview.ShowDialog();
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            exportar();
        }
        public void exportar()
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Document|*.pdf";
            saveFileDialog.Title = "Exportar Reporte PDF";
            saveFileDialog.FileName = "Reporte_Electoral.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                string tempPng = System.IO.Path.Combine(
                    System.IO.Path.GetTempPath(), "reporte_temp.png");

                Bitmap bmpForm = new Bitmap(this.Width, this.Height);
                this.DrawToBitmap(bmpForm, new Rectangle(0, 0, this.Width, this.Height));
                bmpForm.Save(tempPng, System.Drawing.Imaging.ImageFormat.Png);
                bmpForm.Dispose();

                
                using (System.IO.FileStream fs = new System.IO.FileStream(
                    saveFileDialog.FileName, System.IO.FileMode.Create))
                {
                    byte[] imgBytes = System.IO.File.ReadAllBytes(tempPng);
                    string imgB64 = Convert.ToBase64String(imgBytes);

                    string htmlTemp = System.IO.Path.Combine(
                        System.IO.Path.GetTempPath(), "reporte_temp.html");

                    string htmlContent = $@"
                <html>
                <head>
                    <style>
                        body {{ margin: 0; padding: 0; }}
                        img {{ width: 100%; height: auto; }}
                    </style>
                </head>
                <body>
                    <img src='data:image/png;base64,{imgB64}' />
                </body>
                </html>";

                    System.IO.File.WriteAllText(htmlTemp, htmlContent);

                    
                    WebBrowser wb = new WebBrowser();
                    wb.Size = new Size(this.Width, this.Height);
                    wb.Navigate(htmlTemp);

                    
                    while (wb.ReadyState != WebBrowserReadyState.Complete)
                        Application.DoEvents();

                    wb.Print(); 
                    wb.Dispose();
                }

                // Limpiar temporales
                if (System.IO.File.Exists(tempPng))
                    System.IO.File.Delete(tempPng);

                MessageBox.Show("Reporte enviado a impresión/PDF", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
              "¿Está seguro que desea salir?",
              "Confirmar salida",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question
               );
            if (resultado == DialogResult.Yes)
            {
                frmMenuOpciones frm = Application.OpenForms["frmMenuOpciones"] as frmMenuOpciones;
                if (frm != null)
                {
                    frm.Show();
                }
                this.Hide();
            }
        }
    }
}
    

