using Dato;
using Dato.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClientNegocio
    {
        private static DateClient metodo = new DateClient();

        public List<Cliente> ListDate()
        {
            return metodo.ToList();
        }
        public static void Add(Cliente client)
        {
            metodo.Add(client);
        }
    }
}
