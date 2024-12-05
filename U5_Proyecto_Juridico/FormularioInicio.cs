using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_Proyecto_Juridico
{
    public partial class FormularioInicio : Form
    {
        public FormularioInicio()
        {
            InitializeComponent();
        }

        private void ClientesButton_Click(object sender, EventArgs e)
        {
            Form clientes = new ClientesForm();
            clientes.Show();
        }
    }
}
