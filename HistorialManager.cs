using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorador_Web
{
    internal class HistorialManager
    {
        public static List<string> Historial { get; } = new List<string>();
        public static Dictionary<string, DateTime> UltimaVisita { get; } = new Dictionary<string, DateTime>();

        public static void AgregarUrl(string url)
        {
            if (!Historial.Contains(url))
            {
                Historial.Add(url);
            }
            UltimaVisita[url] = DateTime.Now;
        }

        public static List<string> ObtenerHistorial()
        {
            return Historial;
        }

        public static DateTime ObtenerUltimaVisita(string url)
        {
            return UltimaVisita.ContainsKey(url) ? UltimaVisita[url] : DateTime.MinValue;
        }
    }
}
