using Ado.NetTEntityFramework6._0.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado.NetTEntityFramework6._0
{
    public partial class Registro : Form
    {
        public int? IdCliente;
        Cliente cliente = null;
        public Registro(int? IdCliente = null)
        {
            InitializeComponent();
            this.IdCliente = IdCliente;
            if (IdCliente != null)
            {
                date();
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            using (PruebaTecnicaEntities db = new PruebaTecnicaEntities())
            {
                if (IdCliente == null)
                {
                    cliente = new Cliente();
                }
                cliente.Nombres = textNombre.Text;
                cliente.Apellidos = textApellido.Text;
                cliente.Direccion = textDireccion.Text;
                if (IdCliente == null)
                {
                    db.Cliente.Add(cliente);
                }
                else
                {
                    db.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();
                this.Close();
            }
        }

        public void date()
        {
            using (PruebaTecnicaEntities db = new PruebaTecnicaEntities())
            {
                cliente = db.Cliente.Find(IdCliente);
                textNombre.Text = cliente.Nombres;
                textApellido.Text = cliente.Apellidos;
                textDireccion.Text = cliente.Direccion;

            }
        }

    }
}
