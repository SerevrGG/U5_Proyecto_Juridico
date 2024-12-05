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
        public int idcliente { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public string email { get; set; }

        public string telefono { get; set; }

        public string tipocaso { get; set; }


        ClaseConexion con = new ClaseConexion();

        public DataTable MuestraClientes()
        {
            DataTable table = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(con.Cadena()))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("VER_CLIENTES", connection))
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

        public void agregarcliente(ClaseCliente cl)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(con.Cadena()))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("INSERTAR_CLIENTE", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ID_CLIENTE", cl.idcliente);
                        cmd.Parameters.AddWithValue("@NOMBRE", cl.nombre);
                        cmd.Parameters.AddWithValue("@APELLIDO", cl.apellido);
                        cmd.Parameters.AddWithValue("@EMAIL", cl.email);
                        cmd.Parameters.AddWithValue("@TELEFONO", cl.telefono);
                        cmd.Parameters.AddWithValue("@TIPO_CASO", cl.tipocaso);

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

        public void EliminarCliente(ClaseCliente cl)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(con.Cadena()))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("ELIMINAR_CLIENTE", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID_CLIENTE", cl.idcliente);

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
                    using (SqlCommand cmd = new SqlCommand("ACTUALIZAR_CLIENTE", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ID_CLIENTE", cl.idcliente);
                        cmd.Parameters.AddWithValue("@NOMBRE", cl.nombre);
                        cmd.Parameters.AddWithValue("@APELLIDO", cl.apellido);
                        cmd.Parameters.AddWithValue("@EMAIL", cl.email);
                        cmd.Parameters.AddWithValue("@TELEFONO", cl.telefono);
                        cmd.Parameters.AddWithValue("@TIPO_CASO", cl.tipocaso);

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
