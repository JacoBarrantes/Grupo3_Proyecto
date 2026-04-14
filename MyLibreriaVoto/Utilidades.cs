using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibreriaVoto
{
    public class Utilidades
    {

        public static DataSet ejecutar(string comando)
        {
            SqlConnection conn = new SqlConnection("Data Source=Jacob;Initial Catalog=SistemaVotacion2026_2030;Integrated Security=True;Encrypt=True;");
            conn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter(comando, conn);
            adaptador.Fill(ds);
            conn.Close();
            return ds;
        }

        public static string codificar(string contrasena)
        {

            byte[] datos = Encoding.UTF8.GetBytes(contrasena);
            return System.Convert.ToBase64String(datos);

        }

        public static string decodificar(string contrasena)
        {
            byte[] datos = Convert.FromBase64String(contrasena);
            return Encoding.UTF8.GetString(datos, 0, datos.Length);
        }

        public static int ejecutarAccion(string comando)
        {
           
            
                SqlConnection conn = new SqlConnection("Data Source=Jacob;Initial Catalog=SistemaVotacion2026_2030;Integrated Security=True;");
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                int filas = cmd.ExecuteNonQuery();
                conn.Close();
                return filas;
            
           
        }
    }

}

