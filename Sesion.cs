using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupo3_Proyecto
{
    public static class Sesion
    {

        public static string Cedula { get;  set; }
        public static string Perfil { get;  set; }   // "ADMIN" o "VOTANTE"
        public static int Rol { get; set; }


        public static bool Activa => !string.IsNullOrWhiteSpace(Cedula);

        public static void Iniciar(string cedula, string perfil)
        {
            Cedula = cedula;
            Perfil = perfil;
        }

        public static void Cerrar()
        {
            Cedula = null;
            Perfil = null;
        }

  

    }
}
