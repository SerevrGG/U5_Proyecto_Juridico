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
                cliente.clave_cliente = int.Parse(tbx_Clave.Text.Replace("-", ""));
                cliente.nombre = tbx_Nombre.Text;
                cliente.direccion = tbx_Direccion.Text;
                cliente.telefono = tbx_Telefono.Text;


                cliente.agregarcliente(cliente);
                //MessageBox.Show("Cliente agregado exitosamente", "Mi Super", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbx_Clave.Clear();
                tbx_Nombre.Clear();
                tbx_Direccion.Clear();
                tbx_Telefono.Clear();
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
                cliente.clave_cliente = int.Parse(tbx_Clave.Text.Replace("-", ""));
                cliente.nombre = tbx_Nombre.Text;
                cliente.direccion = tbx_Direccion.Text;
                cliente.telefono = tbx_Telefono.Text;

                cliente.ActualizarCliente(cliente);
                tbx_Clave.Clear();
                tbx_Nombre.Clear();
                tbx_Direccion.Clear();
                tbx_Telefono.Clear();
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
                cliente.clave_cliente = int.Parse(tbx_Clave.Text.Replace("-", ""));
                cliente.nombre = tbx_Nombre.Text;
                cliente.direccion = tbx_Direccion.Text;
                cliente.telefono = tbx_Telefono.Text;

                cliente.EliminarCliente(cliente);
                tbx_Clave.Clear();
                tbx_Nombre.Clear();
                tbx_Direccion.Clear();
                tbx_Telefono.Clear();
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
