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
    public partial class ClientesForm : Form
    {
        ClaseCliente cliente = new ClaseCliente();

        public void MostrarCliente()
        {
            try
            {
                DataTable dt = cliente.MuestraClientes();
                if (dt != null)
                {
                    dtg_Clientes.DataSource = dt;
                    dtg_Clientes.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public ClientesForm()
        {
            InitializeComponent();
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            try
            {
                MostrarCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.idcliente = int.Parse(tbx_idCliente.Text.Replace("-", ""));
                cliente.nombre = tbx_Nombre.Text;
                cliente.apellido = tbx_Apellido.Text;
                cliente.email = tbx_Email.Text;
                cliente.telefono = tbx_Telefono.Text;
                cliente.tipocaso = tbx_tipoCaso.Text;


                cliente.agregarcliente(cliente);

                tbx_idCliente.Clear();
                tbx_Nombre.Clear();
                tbx_Apellido.Clear();
                tbx_Email.Clear();
                tbx_Telefono.Clear();
                tbx_tipoCaso.Clear();
                MostrarCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.idcliente = int.Parse(tbx_idCliente.Text.Replace("-", ""));
                cliente.nombre = tbx_Nombre.Text;
                cliente.apellido = tbx_Apellido.Text;
                cliente.email = tbx_Email.Text;
                cliente.telefono = tbx_Telefono.Text;
                cliente.tipocaso = tbx_tipoCaso.Text;

                cliente.ActualizarCliente(cliente);

                tbx_idCliente.Clear();
                tbx_Nombre.Clear();
                tbx_Apellido.Clear();
                tbx_Email.Clear();
                tbx_Telefono.Clear();
                tbx_tipoCaso.Clear();
                MostrarCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.idcliente = int.Parse(tbx_idCliente.Text.Replace("-", ""));
                cliente.nombre = tbx_Nombre.Text;
                cliente.apellido = tbx_Apellido.Text;
                cliente.email = tbx_Email.Text;
                cliente.telefono = tbx_Telefono.Text;
                cliente.tipocaso = tbx_tipoCaso.Text;

                cliente.EliminarCliente(cliente);

                tbx_idCliente.Clear();
                tbx_Nombre.Clear();
                tbx_Apellido.Clear();
                tbx_Email.Clear();
                tbx_Telefono.Clear();
                tbx_tipoCaso.Clear();
                MostrarCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
