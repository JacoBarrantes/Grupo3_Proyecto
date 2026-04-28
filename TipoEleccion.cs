using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MyLibreriaVoto;

namespace grupo3_Proyecto
{
    public partial class TipoEleccion : Form
    {

        int idSeleccionado = 0;
        public TipoEleccion()
        {
            InitializeComponent();
        }

        private void TipoEleccion_Load(object sender, EventArgs e)
        {
            CargarTipoEleccion();
        }

        void CargarTipoEleccion()
        {
            DataSet ds = Utilidades.ejecutar("SELECT * FROM TipoEleccion");
            dgvTipoEleccion.DataSource = ds.Tables[0];
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Debe ingresar una descripción");
                    return;
                }

                Utilidades.ejecutarAccion(
                    "INSERT INTO TipoEleccion (Descripcion) VALUES (@Descripcion)",
                    new SqlParameter("@Descripcion", txtDescripcion.Text)
                );

                MessageBox.Show("Registro guardado correctamente");

                CargarTipoEleccion();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvTipoEleccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvTipoEleccion.Rows[e.RowIndex];

                idSeleccionado = Convert.ToInt32(fila.Cells["IdTipoEleccion"].Value);
                txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }

            Utilidades.ejecutarAccion(
                "UPDATE TipoEleccion SET Descripcion = @Descripcion WHERE IdTipoEleccion = @Id",
                new SqlParameter("@Descripcion", txtDescripcion.Text),
                new SqlParameter("@Id", idSeleccionado)
            );

            MessageBox.Show("Registro actualizado");

            CargarTipoEleccion();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }

            Utilidades.ejecutarAccion(
                "DELETE FROM TipoEleccion WHERE IdTipoEleccion = @Id",
                new SqlParameter("@Id", idSeleccionado)
            );

            MessageBox.Show("Registro eliminado");

            CargarTipoEleccion();
            Limpiar();
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        void Limpiar()
        {
            txtDescripcion.Clear();
            idSeleccionado = 0;
        }




    }
}
