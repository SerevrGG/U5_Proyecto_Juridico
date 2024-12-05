using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_Proyecto_Juridico
{
    internal class ClaseCliente
    {
        public int clave_cliente { get; set; }

        public string nombre { get; set; }

        public string direccion { get; set; }

        public string telefono { get; set; }


        ClaseConexion con = new ClaseConexion();

        public void agregarcliente(ClaseCliente cl)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(con.Cadena()))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("INSERTA_CLIENTE", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@wclave_cliente", cl.clave_cliente);
                        cmd.Parameters.AddWithValue("@wnombre", cl.nombre);
                        cmd.Parameters.AddWithValue("@wdireccion", cl.direccion);
                        cmd.Parameters.AddWithValue("@wtelefono", cl.telefono);

                        // Parámetro de salida
                        SqlParameter mensajeParam = new SqlParameter("@mensajeSalida", SqlDbType.VarChar, 100)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(mensajeParam);

                        cmd.ExecuteNonQuery();

                        // Obtener el mensaje del parámetro de salida
                        string mensaje = mensajeParam.Value.ToString();
                        MessageBox.Show(mensaje);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable MuestraClientes()
        {
            //SqlConnection Conexion = new SqlConnection(claseConexion.Conexion);
            //SqlCommand cmd = new SqlCommand("SELECT * FROM CLIENTES ORDER BY nombre", Conexion);
            //Conexion.Open();
            //DataTable Tab = new DataTable();
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //adapter.Fill(Tab);
            //Conexion.Close();
            //if (Tab.Rows.Count > 0) return Tab;
            //else return null;

            DataTable table = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(con.Cadena()))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("VISUALIZAR_CLIENTES", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Usamos un SqlDataAdapter para llenar el DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(table);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar clientes: {ex.Message}");
            }

            return table; // Devuelve el DataTable lleno o vacío si hubo un error
        }

        public void EliminarCliente(ClaseCliente cl)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(con.Cadena()))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("ELIMINAR_CLIENTES", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@wclave_cliente", cl.clave_cliente);
                        // Parámetro de salida
                        SqlParameter mensajeParam = new SqlParameter("@mensajeSalida", SqlDbType.VarChar, 100)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(mensajeParam);

                        cmd.ExecuteNonQuery();

                        // Obtener el mensaje del parámetro de salida
                        string mensaje = mensajeParam.Value.ToString();
                        MessageBox.Show(mensaje);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ActualizarCliente(ClaseCliente cl)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(con.Cadena()))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("ACTUALIZAR_CLIENTES", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@wclave_cliente", cl.clave_cliente);
                        cmd.Parameters.AddWithValue("@wnombre", cl.nombre);
                        cmd.Parameters.AddWithValue("@wdireccion", cl.direccion);
                        cmd.Parameters.AddWithValue("@wtelefono", cl.telefono);

                        // Parámetro de salida
                        SqlParameter mensajeParam = new SqlParameter("@mensajeSalida", SqlDbType.VarChar, 100)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(mensajeParam);

                        cmd.ExecuteNonQuery();

                        // Obtener el mensaje del parámetro de salida
                        string mensaje = mensajeParam.Value.ToString();
                        MessageBox.Show(mensaje);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
