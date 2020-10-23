using Dato;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        ClientNegocio metodonegocio = new ClientNegocio();
        EntityClient entityClient = new EntityClient();
        private void Guardar_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void Add()
        {
            entityClient.Nombres = txtNombres.Text;
            entityClient.Apellidos = textApellidos.Text;
            entityClient.Direccion = textDireccion.Text;

            metodonegocio.Add(entityClient);
        }
    }
}
