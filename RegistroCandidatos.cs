
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibreriaVoto;

namespace grupo3_Proyecto
{
    public partial class frmRegistroCandidatos : Form
    {
        private bool _cargandoCombos = false;
        public frmRegistroCandidatos()
        {
            InitializeComponent();
        }

        private void frmRegistroCandidatos_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }




        private void CargarCombos()
        {
            try
            {
                _cargandoCombos = true;

                // ===== 1) PARTIDOS =====
                DataSet dsPartidos = Utilidades.ejecutar(
                    "SELECT IdPartido, NombrePartido FROM PartidosPoliticos ORDER BY NombrePartido"
                );


                cmbPartido.DisplayMember = "NombrePartido";
                cmbPartido.ValueMember = "IdPartido";
                cmbPartido.DataSource = dsPartidos.Tables[0];
                cmbPartido.DropDownStyle = ComboBoxStyle.DropDownList;

                // ===== 2) TIPO ELECCIÓN =====
                DataSet dsTipos = Utilidades.ejecutar(
                    "SELECT IdTipoEleccion, Descripcion FROM TipoEleccion ORDER BY IdTipoEleccion"
                );

                cmbCandidatura.DisplayMember = "Descripcion";
                cmbCandidatura.ValueMember = "IdTipoEleccion";
                cmbCandidatura.DataSource = dsTipos.Tables[0];
                cmbCandidatura.DropDownStyle = ComboBoxStyle.DropDownList;


                // ===== 3) PROVINCIAS (DISTINCT) =====
                DataSet dsProv = Utilidades.ejecutar(
                    "SELECT DISTINCT Provincia FROM DistritoElectoral WHERE Provincia IS NOT NULL ORDER BY Provincia"
                );

                cmbProvincia.DisplayMember = "Provincia";
                cmbProvincia.ValueMember = "Provincia";
                cmbProvincia.DataSource = dsProv.Tables[0];
                cmbProvincia.DropDownStyle = ComboBoxStyle.DropDownList;

                _cargandoCombos = false;
            }
            catch (Exception ex)
            {
                _cargandoCombos = false;
                MessageBox.Show("Error cargando catálogos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtIDUsuarioCandidato_TextChanged(object sender, EventArgs e)
        {


            try
            {
                string cedula = txtIDUsuarioCandidato.Text.Trim();

                // Para no consultar por cada tecla, validamos mínimo de caracteres
                if (cedula.Length < 6)
                {
                    txtNombreCompleto.Text = "";
                    return;
                }

                string sql = "SELECT Nombre, PrimerApellido, SegundoApellido FROM PadronNacional WHERE Cedula = @cedula";

                DataSet ds = Utilidades.ejecutar(sql, new SqlParameter("@cedula", cedula));


                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    string nombre = ds.Tables[0].Rows[0]["Nombre"].ToString();
                    string ap1 = ds.Tables[0].Rows[0]["PrimerApellido"].ToString();
                    string ap2 = ds.Tables[0].Rows[0]["SegundoApellido"].ToString();

                    txtNombreCompleto.Text = $"{nombre} {ap1} {ap2}".Trim();
                }
                else
                {
                    txtNombreCompleto.Text = "No existe en padrón";
                }



            }
            catch
            {
                
            }
        }




        private void cmbPartido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_cargandoCombos) return;
        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cargandoCombos) return;

        }

        private void cmbCandidatura_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void txtNombreCompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrarCandidato_Click(object sender, EventArgs e)
        {
            try
            {
                string cedula = txtIDUsuarioCandidato.Text.Trim();

                if (string.IsNullOrWhiteSpace(cedula))
                {
                    MessageBox.Show("Debe ingresar una cédula.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbPartido.SelectedValue == null || cmbCandidatura.SelectedValue == null || cmbProvincia.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar Partido, Candidatura y Provincia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ✅ AQUÍ se declaran (esto evita el CS0103)
                int idPartido = Convert.ToInt32(cmbPartido.SelectedValue);
                int idTipo = Convert.ToInt32(cmbCandidatura.SelectedValue);
                string provincia = cmbProvincia.SelectedValue.ToString();

                // 1) Traer nombre y apellidos desde padrón
                string sqlPadron = "SELECT Nombre, PrimerApellido, SegundoApellido FROM PadronNacional WHERE Cedula = @cedula";
                DataSet dsP = Utilidades.ejecutar(sqlPadron, new SqlParameter("@cedula", cedula));

                if (dsP.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("La cédula no existe en el padrón.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string nombre = dsP.Tables[0].Rows[0]["Nombre"].ToString();
                string apellidos = (dsP.Tables[0].Rows[0]["PrimerApellido"].ToString() + " " +
                                    dsP.Tables[0].Rows[0]["SegundoApellido"].ToString()).Trim();

                // 2) Foto (si tienes txtFoto; si no, queda NULL)
                string foto = null;
                if (this.Controls.Find("txtFoto", true).FirstOrDefault() is TextBox t)
                    foto = string.IsNullOrWhiteSpace(t.Text) ? null : t.Text.Trim();

                // 3) Insert
                string sqlInsert =
                    "INSERT INTO Candidatos (Nombre, Apellidos, Provincia, IdPartido, IdTipoEleccion, Foto) " +
                    "VALUES (@nombre, @apellidos, @provincia, @idPartido, @idTipo, @foto)";

                int filas = Utilidades.ejecutarAccion(sqlInsert,
                    new SqlParameter("@nombre", nombre),
                    new SqlParameter("@apellidos", apellidos),
                    new SqlParameter("@provincia", provincia),
                    new SqlParameter("@idPartido", idPartido),
                    new SqlParameter("@idTipo", idTipo),
                    new SqlParameter("@foto", (object)foto ?? DBNull.Value)
                );

                MessageBox.Show("Candidato registrado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void LimpiarFormulario()
        {
            txtIDUsuarioCandidato.Clear();
            txtNombreCompleto.Clear();

            // Mantiene combos cargados
            if (cmbPartido.Items.Count > 0) cmbPartido.SelectedIndex = 0;
            if (cmbCandidatura.Items.Count > 0) cmbCandidatura.SelectedIndex = 0;
            if (cmbProvincia.Items.Count > 0) cmbProvincia.SelectedIndex = 0;

            // Si existe txtFoto lo limpia
            Control posibleTxtFoto = this.Controls.Find("txtFoto", true).FirstOrDefault();
            if (posibleTxtFoto != null && posibleTxtFoto is TextBox)
                (posibleTxtFoto as TextBox).Clear();
        }





        private void btnSalirAlMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
