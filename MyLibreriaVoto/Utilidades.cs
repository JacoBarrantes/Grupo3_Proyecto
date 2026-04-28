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
        //Data Source=Kevin-Leon\MSSSQLSERVER2026;Initial Catalog=SistemaVotacion2026_2030;Integrated Security=True;
        private static readonly string _cnn = @"Data Source=Kevin-Leon\MSSSQLSERVER2026;Initial Catalog=SistemaVotacion2026_2030;Integrated Security=True";
        public static DataSet ejecutar(string comando)
        {
            using (SqlConnection conn = new SqlConnection(_cnn))
            {
                conn.Open();
                DataSet ds = new DataSet();
                using (SqlDataAdapter adaptador = new SqlDataAdapter(comando, conn))
                {
                    adaptador.Fill(ds);
                }
                return ds;
            }
        }

        public static int ejecutarAccion(string comando)
        {
            using (SqlConnection conn = new SqlConnection(_cnn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(comando, conn))
                {
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static DataSet ejecutar(string comando, params SqlParameter[] parametros)
        {
            using (SqlConnection conn = new SqlConnection(_cnn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(comando, conn))
                {
                    if (parametros != null && parametros.Length > 0)
                        cmd.Parameters.AddRange(parametros);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        return ds;
                    }
                }
            }
        }

        public static int ejecutarAccion(string comando, params SqlParameter[] parametros)
        {
            using (SqlConnection conn = new SqlConnection(_cnn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(comando, conn))
                {
                    if (parametros != null && parametros.Length > 0)
                        cmd.Parameters.AddRange(parametros);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static object ejecutarEscalar(string comando, params SqlParameter[] parametros)
        {
            using (SqlConnection conn = new SqlConnection(_cnn))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(comando, conn))
                {
                    if (parametros != null && parametros.Length > 0)
                        cmd.Parameters.AddRange(parametros);

                    return cmd.ExecuteScalar();
                }
            }
        }

        public static string codificar(string contrasena)
        {
            byte[] datos = Encoding.UTF8.GetBytes(contrasena);
            return Convert.ToBase64String(datos);
        }

        public static string decodificar(string contrasena)
        {
            byte[] datos = Convert.FromBase64String(contrasena);
            return Encoding.UTF8.GetString(datos, 0, datos.Length);
        }
    }
}            
    

