using MyLibreriaVoto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupo3_Proyecto
{
    public partial class frmInformes : Form
    {
        public frmInformes()
        {
            InitializeComponent();
        }

        private void frmInformes_Load(object sender, EventArgs e)
        {
            CargarInformeProvincia();
            CargarInformeCandidato();
        }
        private void CargarInformeProvincia()
        {
            string query = @"
                SELECT 
                    d.Provincia,
                    c.Nombre + ' ' + c.Apellidos  AS Candidato,
                    pp.NombrePartido               AS Partido,
                    COUNT(v.IdVoto)                AS TotalVotos,
                    CAST(COUNT(v.IdVoto) * 100.0 /
                        NULLIF((SELECT COUNT(*) FROM Votacion), 0)
                        AS DECIMAL(5,2))           AS Porcentaje
                FROM DistritoElectoral d
                INNER JOIN PadronNacional pn    ON d.CodigoElectoral = pn.CodigoElectoral
                INNER JOIN Votacion v           ON pn.Cedula = v.Cedula
                INNER JOIN Candidatos c         ON v.IdCandidato = c.IdCandidato
                INNER JOIN PartidosPoliticos pp ON c.IdPartido = pp.IdPartido
                GROUP BY d.Provincia, c.Nombre, c.Apellidos, pp.NombrePartido
                ORDER BY d.Provincia, TotalVotos DESC";

            DataSet ds = Utilidades.ejecutar(query);
            dgvProvincia.DataSource = null;
            dgvProvincia.Columns.Clear();
            dgvProvincia.DataSource = ds.Tables[0];

            dgvProvincia.Columns["TotalVotos"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;
            dgvProvincia.Columns["Porcentaje"].DefaultCellStyle.Format = "N2";
            dgvProvincia.Columns["Porcentaje"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;

           //lblProvinciaActualizado.Text = $"Actualizado: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";
        }

        // ─── CANDIDATO ────────────────────────────────────────────────────────
        private void CargarInformeCandidato()
        {
            string query = @"
                SELECT 
                    c.Nombre + ' ' + c.Apellidos  AS Candidato,
                    pp.NombrePartido               AS Partido,
                    te.Descripcion                 AS TipoEleccion,
                    COUNT(v.IdVoto)                AS TotalVotos,
                    CAST(COUNT(v.IdVoto) * 100.0 /
                        NULLIF((SELECT COUNT(*) FROM Votacion), 0)
                        AS DECIMAL(5,2))           AS Porcentaje
                FROM Candidatos c
                INNER JOIN PartidosPoliticos pp ON c.IdPartido = pp.IdPartido
                INNER JOIN TipoEleccion te      ON c.IdTipoEleccion = te.IdTipoEleccion
                LEFT JOIN  Votacion v           ON c.IdCandidato = v.IdCandidato
                GROUP BY c.IdCandidato, c.Nombre, c.Apellidos,
                         pp.NombrePartido, te.Descripcion
                ORDER BY TotalVotos DESC";

            DataSet ds = Utilidades.ejecutar(query);
            dgvCandidato.DataSource = null;
            dgvCandidato.Columns.Clear();
            dgvCandidato.DataSource = ds.Tables[0];

            dgvCandidato.Columns["TotalVotos"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;
            dgvCandidato.Columns["Porcentaje"].DefaultCellStyle.Format = "N2";
            dgvCandidato.Columns["Porcentaje"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;

            if (dgvCandidato.Rows.Count > 0)
                dgvCandidato.Rows[0].DefaultCellStyle.BackColor =
                    System.Drawing.Color.LightGreen;

           // lblCandidatoActualizado.Text = $"Actualizado: {DateTime.Now:dd/MM/yyyy HH:mm:ss}";
        }

        private void btnActualizarProvincia_Click(object sender, EventArgs e)
        {
            CargarInformeProvincia();
        }

        private void btnActualizarCandidato_Click(object sender, EventArgs e)
        {
            CargarInformeCandidato();
        }
    }
}
