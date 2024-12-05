using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace U5_Proyecto_Juridico
{
    internal class ClaseConexion
    {
        private readonly string connectionString;

        public ClaseConexion()
        {
            string nombre_servidor = Dns.GetHostName();
            connectionString = $"Data Source={nombre_servidor};Initial Catalog=JURIDICO_PROYECTO;Integrated Security=True;";
        }

        public string Cadena()
        {
            return connectionString; // Devuelve la cadena de conexión
        }
    }
}
