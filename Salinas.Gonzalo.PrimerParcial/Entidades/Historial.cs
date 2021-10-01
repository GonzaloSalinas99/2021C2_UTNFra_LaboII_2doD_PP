using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Historial
    {
        private static List<Sesion> listaSesiones;

        public static List<Sesion> Sesiones
        { get => listaSesiones;
            set => listaSesiones = value; }

        static Historial()
        {
            Sesiones = new List<Sesion>();
        }

        public static string MostrarHistorial()
        {
            foreach (Sesion sesion in listaSesiones)
            {
                return sesion.ToString();
            }
            return "NO ENCONTRE SESIONES";
        }

          
    }
}
