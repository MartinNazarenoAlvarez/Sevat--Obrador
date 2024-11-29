using MySql.Data.MySqlClient;
using ProyectoObrador.Interfaz;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoObrador.Datos;

namespace ProyectoObrador.Datos
{
    public class DatosEmpleados : IEmpleado
    {
        
        public bool eliminarEmpleado(int _id)
        {
            throw new NotImplementedException();
        }

        public DataTable listarEmpleados()
        {
            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = Conexion.GetConexion().crearConexion();
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();

            try
            {
                MySqlCommand comando = new MySqlCommand("psa_listadoEmpleados", SQLdatos);
                comando.CommandType = CommandType.StoredProcedure;
                
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);

                comando.Dispose();
            }
            catch (Exception ex)
            {
                Funciones.Logs("Datos_metodoListarEmpleado", ex.ToString());
            }
            finally
            {
                if (SQLdatos.State == ConnectionState.Open)
                {
                    SQLdatos.Close();
                }
            }

            return tabla;
        }

        public DataTable listarEmpleadosActivos()
        {
            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = Conexion.GetConexion().crearConexion();
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();

            try
            {
                MySqlCommand comando = new MySqlCommand("psa_listadoEmpleadosActivos", SQLdatos);
                comando.CommandType = CommandType.StoredProcedure;

                resultado = comando.ExecuteReader();
                tabla.Load(resultado);

                comando.Dispose();
            }
            catch (Exception ex)
            {
                Funciones.Logs("Datos_metodoListarEmpleado", ex.ToString());
            }
            finally
            {
                if (SQLdatos.State == ConnectionState.Open)
                {
                    SQLdatos.Close();
                }
            }

            return tabla;
        }

        public DataTable listarEmpleadosInactivos()
        {
            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = Conexion.GetConexion().crearConexion();
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();

            try
            {
                MySqlCommand comando = new MySqlCommand("psa_listadoEmpleadosInactivos", SQLdatos);
                comando.CommandType = CommandType.StoredProcedure;

                resultado = comando.ExecuteReader();
                tabla.Load(resultado);

                comando.Dispose();
            }
            catch (Exception ex)
            {
                Funciones.Logs("Datos_metodoListarEmpleado", ex.ToString());
            }
            finally
            {
                if (SQLdatos.State == ConnectionState.Open)
                {
                    SQLdatos.Close();
                }
            }

            return tabla;
        }

        string IEmpleado.actualizarEmpleado(Empleado _empleado)
        {
            throw new NotImplementedException();
        }

        public string agregarEmpleado(Empleado _empleado)
        {
            MySqlConnection SQLdatos = null;
            string respuesta = "Error al guardar";
            MySqlTransaction tras = null;
            try
            {
                SQLdatos = Conexion.GetConexion().crearConexion();

                /*
                 * esto fue lo que se agrego, el fallo por el cual no se acualizaba la base de datos
                 * era que ya habia una conexion antes, y al intentar re abrirla de nuevo el progrmaa
                 * lanzaba un error y por eso no se ejecutva lo siguiente, pero ya esta, al realizar
                 * esta verificacion no pasa y se actualiza de manera correcta.
                 */

                if (SQLdatos.State == ConnectionState.Closed)
                {
                    SQLdatos.Open();
                }

                tras = SQLdatos.BeginTransaction();
                MySqlCommand comando = new MySqlCommand("asp_guardar_empleado", SQLdatos, tras)
                {
                    CommandType = CommandType.StoredProcedure
                };

                comando.Parameters.Add("_dni", MySqlDbType.VarChar).Value = _empleado.dni;
                comando.Parameters.Add("_apellido", MySqlDbType.VarChar).Value = _empleado.apellido;
                comando.Parameters.Add("_nombre", MySqlDbType.VarChar).Value = _empleado.nombre;
                comando.Parameters.Add("_cargo", MySqlDbType.VarChar).Value = _empleado.cargo;
                comando.Parameters.Add("_telefono", MySqlDbType.VarChar).Value = _empleado.telefono;

                int result = comando.ExecuteNonQuery();
                if (result == 1)
                {
                    tras.Commit();
                    respuesta = "OK";
                }
                else
                {
                    tras.Rollback();
                    Funciones.Logs("Datos_Agregar", "Error: Ninguna fila fue afectada.");
                }
            }
            catch (Exception ex)
            {
                tras?.Rollback();
                Funciones.Logs("Datos_Agregar", respuesta + ">>" + ex.ToString());
            }
            finally
            {
                if (SQLdatos != null && SQLdatos.State == ConnectionState.Open)
                {
                    SQLdatos.Close();
                }
            }
            return respuesta;
        }

        public Empleado buscarXdni(string _dni, bool empleadoInactivosVisibles)
        {
            MySqlConnection SQLdatos = Conexion.GetConexion().crearConexion();
            MySqlDataReader resultado;
            Empleado empleado = null;

            try
            {
                MySqlCommand comando = new MySqlCommand();

                comando = new MySqlCommand("psa_ListarEmpleadoxdni", SQLdatos);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("_dni", _dni);

                resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    bool activo = resultado.GetBoolean(6);

                    // Verifica si se debe mostrar según el estado de empleadoInactivosVisibles
                    if ((empleadoInactivosVisibles && !activo) || (!empleadoInactivosVisibles && activo))
                    {
                        empleado = new Empleado()
                        {
                            idEmpleado = resultado.GetInt32(0),
                            dni = resultado.GetString(1),
                            apellido = resultado.GetString(2),
                            nombre = resultado.GetString(3),
                            cargo = resultado.GetString(4),
                            telefono = resultado.GetString(5),
                            activo = activo
                        };
                    }
                }

                resultado.Close();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                Funciones.Logs("Datos_metodoListarEmpleado", ex.ToString());
            }
            finally
            {
                if (SQLdatos.State == ConnectionState.Open)
                {
                    SQLdatos.Close();
                }
            }

            return empleado;
        }



        public Empleado buscarXid(int _id, bool empleadoInactivosVisibles)
        {
            MySqlConnection SQLdatos = Conexion.GetConexion().crearConexion();
            MySqlCommand comando = new MySqlCommand();
            MySqlDataReader resultado;
            Empleado empleado = null;

            try
            {
                comando = new MySqlCommand("psa_listadoEmpleadosXid", SQLdatos);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("_id", _id);


                resultado = comando.ExecuteReader();
                if (resultado.Read())
                {
                    bool activo = resultado.GetBoolean(6);

                    // Verifica si se debe mostrar según el estado de empleadoInactivosVisibles
                    if ((empleadoInactivosVisibles && !activo) || (!empleadoInactivosVisibles && activo))
                    {
                        empleado = new Empleado()
                        {
                            idEmpleado = resultado.GetInt32(0),
                            dni = resultado.GetString(1),
                            apellido = resultado.GetString(2),
                            nombre = resultado.GetString(3),
                            cargo = resultado.GetString(4),
                            telefono = resultado.GetString(5),
                            activo = activo
                        };
                    }
                }
                resultado.Close();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                Funciones.Logs("Datos_metodolistadoEmpleadosXid", ex.ToString());
            }
            finally
            {
                if (SQLdatos.State == ConnectionState.Open)
                {
                    SQLdatos.Close();
                }
            }
            return empleado;
        }


        public List<Empleado> listadoXApellido(string _apellido, bool empleadoInactivosVisibles)
        {
            MySqlConnection SQLdatos = Conexion.GetConexion().crearConexion();
            MySqlDataReader resultado;
            List<Empleado> empleados = new List<Empleado>();

            try
            {
                MySqlCommand comando = new MySqlCommand("psa_listadoEmpleadosXApellido", SQLdatos);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("_apellido", _apellido);
                comando.Parameters.AddWithValue("_empleadoInactivosVisibles", empleadoInactivosVisibles);

                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    bool activo = resultado.GetBoolean(6);

                    // Verifica si se debe agregar según el estado de empleadoInactivosVisibles
                    // Cambié aquí la lógica para incluir empleados inactivos si empleadoInactivosVisibles es verdadero
                    if (empleadoInactivosVisibles || activo)
                    {
                        Empleado empleado = new Empleado()
                        {
                            idEmpleado = resultado.GetInt32(0),
                            dni = resultado.GetString(1),
                            apellido = resultado.GetString(2),
                            nombre = resultado.GetString(3),
                            cargo = resultado.GetString(4),
                            telefono = resultado.GetString(5),
                            activo = activo
                        };
                        empleados.Add(empleado);
                    }
                }
                resultado.Close();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                Funciones.Logs("Datos_ListadoXApellido", $"Error: {ex.Message} - Detalle: {ex.ToString()}");
            }
            finally
            {
                if (SQLdatos.State == ConnectionState.Open)
                {
                    SQLdatos.Close();
                }
            }
            return empleados;
        }
    }
}
