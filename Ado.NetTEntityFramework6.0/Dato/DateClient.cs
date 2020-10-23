using Dato.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dato
{
    public class DateClient
    {
        private PruebaTecnicaEntities modeldb = new PruebaTecnicaEntities();

        public void Add(Cliente client)
        {
            modeldb.Cliente.Add(client);
            modeldb.SaveChanges();
        }

        public List<Cliente> ToList()
        {
            return modeldb.Cliente.ToList();
        }
    }
}
