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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refres();
        }

        private void Refres()
        {
            using (PruebaTecnicaEntities db = new PruebaTecnicaEntities())
            {
                var lst = from d in db.Cliente
                          select d;
                dataGridView1.DataSource = lst.ToList();
            }
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        private void Agregar_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.ShowDialog();
            Refres();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            int? IdCliente = GetId();
            if (IdCliente != null)
            {
                Registro registro = new Registro(IdCliente);
                registro.ShowDialog();
                Refres();
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            int? IdCliente = GetId();
            if (IdCliente != null)
            {
                using (PruebaTecnicaEntities db = new PruebaTecnicaEntities())
                {
                    Cliente cliente = db.Cliente.Find(IdCliente);
                    db.Cliente.Remove(cliente);
                    db.SaveChanges();
                }
                    Refres();
            }
        }
    }
}
