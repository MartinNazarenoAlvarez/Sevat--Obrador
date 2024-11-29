using MySql.Data.MySqlClient;
using ProyectoObrador.Interfaz;
using ProyectoObrador.Vistas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoObrador.Datos
{
    internal class DatosAsignaciones : IAsignacion
    {
        public string actualizarAsignacion(Asignacion _asignacion, Asignaciones form, bool asignacionesInactivas)
        {
            MySqlConnection SQLDatos = Conexion.GetConexion().crearConexion();
            MySqlTransaction tras = null;
            string respuesta = "Error al actualizar";

            try
            {
                if (SQLDatos.State == ConnectionState.Closed)
                {
                    SQLDatos.Open();
                }
                tras = SQLDatos.BeginTransaction();
                MySqlCommand comando = new MySqlCommand("asp_actualizar_asignacion", SQLDatos, tras)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.AddWithValue("_id_asignacion", _asignacion.idAsignacion);
                comando.Parameters.AddWithValue("_id_herramienta", _asignacion.id_herramienta);
                comando.Parameters.AddWithValue("_id_empleado", _asignacion.id_empleado);
                comando.Parameters.AddWithValue("_fechaAsignacion", _asignacion.fechaAsignacion);
                comando.Parameters.AddWithValue("_fechaDevolucion", _asignacion.fechaDevolucion);
                comando.Parameters.AddWithValue("_activo", _asignacion.activo);

                int rowsAffected = comando.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    tras.Commit();
                    MessageBox.Show("Asignacion actualizada", "Informacion", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    respuesta = "Actualizacion exitosa";
                    if (!asignacionesInactivas)
                    {
                        form.ActualizarInterfaz();
                    }
                    else
                    {
                        form.ActualizarInterfazInactivos();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Error al actualizar empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Funciones.Logs("ActualizarAsignaciones", ex.ToString());
            }
            finally
            {
                if (SQLDatos.State == ConnectionState.Open)
                {
                    SQLDatos.Close();
                }
            }
            return respuesta;
        }

        public string agregarAsignacion(Asignacion _asignacion)
        {
            MySqlConnection SQLdatos = Conexion.GetConexion().crearConexion();
            string respuesta = "Error al guardar";
            MySqlTransaction tras = null;
            try
            {
                if (SQLdatos.State == ConnectionState.Closed)
                {
                    SQLdatos.Open();
                }
                tras = SQLdatos.BeginTransaction();
                MySqlCommand comando = new MySqlCommand("asp_guardar_asignacion", SQLdatos, tras)
                {
                    CommandType = CommandType.StoredProcedure
                };

                comando.Parameters.Add("_id_herramienta", MySqlDbType.VarChar).Value = _asignacion.id_herramienta;
                comando.Parameters.Add("_id_empleado", MySqlDbType.VarChar).Value = _asignacion.id_empleado;
                comando.Parameters.Add("_fechaAsignacion", MySqlDbType.DateTime).Value = _asignacion.fechaAsignacion;
                comando.Parameters.Add("_fechaDevolucion", MySqlDbType.DateTime).Value = _asignacion.fechaDevolucion;

                int result = comando.ExecuteNonQuery();
                if (result == 1)
                {
                    MySqlCommand actualizarComando = new MySqlCommand("asp_actualizar_estado_herramienta", SQLdatos, tras)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    actualizarComando.Parameters.Add("_id_herramienta", MySqlDbType.Int32).Value = _asignacion.id_herramienta;
                    actualizarComando.Parameters.Add("_disponible", MySqlDbType.Byte).Value = false;
                    int updateResult = actualizarComando.ExecuteNonQuery();

                    if (updateResult == 1)
                    {
                        tras.Commit();
                        respuesta = "OK";
                    }
                    else
                    {
                        tras.Rollback();
                        respuesta = "Error al actualizar el estado de la herramienta";
                    }
                }
            }
            catch (Exception ex)
            {
                Funciones.Logs("agregarAsignaciones", ex.ToString());
            }
            finally
            {
                if (SQLdatos.State == ConnectionState.Open)
                {
                    SQLdatos.Close();
                }
            }
            return respuesta;
        }

        public List<Asignacion> buscarAsignacionPorFechas(DateTime fechaDesde, DateTime fechaHasta)
        {
            MySqlConnection SQLDatos = Conexion.GetConexion().crearConexion();
            MySqlDataReader resultado;
            List<Asignacion> asignaciones = new List<Asignacion>();

            try
            {
                if (SQLDatos.State == ConnectionState.Closed)
                {
                    SQLDatos.Open();
                }
                MySqlCommand cmd = new MySqlCommand("asp_buscarAsignacionPorFechas", SQLDatos)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("_fechaDesde", fechaDesde);
                cmd.Parameters.AddWithValue("_fechaHasta", fechaHasta);

                resultado = cmd.ExecuteReader();

                while (resultado.Read())
                {
                    Asignacion asignacion = new Asignacion()
                    {
                        idAsignacion = resultado.GetInt32(0),
                        id_herramienta = resultado.GetInt32(1),
                        id_empleado = resultado.GetInt32(2),
                        fechaAsignacion = resultado.GetDateTime(3),
                        fechaDevolucion = resultado.GetDateTime(4),
                        activo = resultado.GetBoolean(5),
                    };
                    asignaciones.Add(asignacion);
                }

                resultado.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Funciones.Logs("Datos_BuscarAsignacionPorFechas", $"Error {ex.Message} - Detalle: {ex}");
            }
            finally
            {
                if (SQLDatos.State == ConnectionState.Open)
                {
                    SQLDatos.Close();
                }
            }
            return asignaciones;
        }

        public List<Asignacion> listarHerramientasPrestamoInactivo(int idEmpleado)
        {
            MySqlConnection SQLdatos = Conexion.GetConexion().crearConexion();
            MySqlDataReader resultado;
            List<Asignacion> asignaciones = new List<Asignacion>();

            try
            {
                if (SQLdatos.State == ConnectionState.Closed)
                {
                    SQLdatos.Open();
                }
                MySqlCommand comando = new MySqlCommand("asp_listarHerramientasPrestamoActivo", SQLdatos)
                {
                    CommandType = CommandType.StoredProcedure
                };

                comando.Parameters.AddWithValue("_id_empleado", idEmpleado);

                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    Asignacion asignacion = new Asignacion
                    {
                        idAsignacion = resultado.GetInt32(0),
                        id_herramienta = resultado.GetInt32(1),
                        id_empleado = resultado.GetInt32(2),
                        fechaAsignacion = resultado.GetDateTime(3),
                        fechaDevolucion = resultado.GetDateTime(4),
                        activo = resultado.GetBoolean(5)
                    };
                    asignaciones.Add(asignacion);
                }

                resultado.Close();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                Funciones.Logs("Datos_listadoAsignacionPorEmpleado", $"Error: {ex.Message} - Detalle: {ex}");
            }
            finally
            {
                if (SQLdatos.State == ConnectionState.Open)
                {
                    SQLdatos.Close();
                }
            }
            return asignaciones;
        }

        public List<Asignacion> buscarAsignacionPorId(int idEmpleado)
        {
            MySqlConnection SQLdatos = Conexion.GetConexion().crearConexion();
            MySqlDataReader resultado;
            List<Asignacion> asignaciones = new List<Asignacion>();

            try
            {
                if (SQLdatos.State == ConnectionState.Closed)
                {
                    SQLdatos.Open();
                }
                MySqlCommand comando = new MySqlCommand("asp_buscarAsignacionId", SQLdatos)
                {
                    CommandType = CommandType.StoredProcedure
                };

                comando.Parameters.AddWithValue("_id_empleado", idEmpleado);

                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    Asignacion asignacion = new Asignacion
                    {
                        idAsignacion = resultado.GetInt32(0),
                        id_herramienta = resultado.GetInt32(1),
                        id_empleado = resultado.GetInt32(2),
                        fechaAsignacion = resultado.GetDateTime(3),
                        fechaDevolucion = resultado.GetDateTime(4),
                        activo = resultado.GetBoolean(5)
                    };
                    asignaciones.Add(asignacion);
                }

                resultado.Close();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                Funciones.Logs("Datos_listadoAsignacionPorEmpleado", $"Error: {ex.Message} - Detalle: {ex}");
            }
            finally
            {
                if (SQLdatos.State == ConnectionState.Open)
                {
                    SQLdatos.Close();
                }
            }
            return asignaciones;
        }

        public List<Asignacion> buscarAsignacionPorIdYFechas(int idEmpleado, DateTime fechaDesde, DateTime fechaHasta)
        {
            MySqlConnection SQLdatos = Conexion.GetConexion().crearConexion();
            MySqlDataReader resultado;
            List<Asignacion> asignaciones = new List<Asignacion>();

            try
            {
                if (SQLdatos.State == ConnectionState.Closed)
                {
                    SQLdatos.Open();
                }
                MySqlCommand comando = new MySqlCommand("asp_buscarAsignacionPorIdYFechas", SQLdatos)
                {
                    CommandType = CommandType.StoredProcedure
                };

                // Se añaden los parámetros para el ID del empleado y el rango de fechas
                comando.Parameters.AddWithValue("_id_empleado", idEmpleado);
                comando.Parameters.AddWithValue("_fechaDesde", fechaDesde);
                comando.Parameters.AddWithValue("_fechaHasta", fechaHasta);

                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    Asignacion asignacion = new Asignacion
                    {
                        idAsignacion = resultado.GetInt32(0),
                        id_herramienta = resultado.GetInt32(1),
                        id_empleado = resultado.GetInt32(2),
                        fechaAsignacion = resultado.GetDateTime(3),
                        fechaDevolucion = resultado.GetDateTime(4),
                        activo = resultado.GetBoolean(5)
                    };
                    asignaciones.Add(asignacion);
                }

                resultado.Close();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                Funciones.Logs("Datos_buscarAsignacionPorIdYFechas", $"Error: {ex.Message} - Detalle: {ex}");
            }
            finally
            {
                if (SQLdatos.State == ConnectionState.Open)
                {
                    SQLdatos.Close();
                }
            }
            return asignaciones;
        }


        public bool eliminarAsignacion(int _id)
        {
            throw new NotImplementedException();
        }

        public List<Asignacion> listarAsignaciones()
        {
            MySqlConnection SQLdatos = Conexion.GetConexion().crearConexion();
            MySqlDataReader resultado;
            List<Asignacion> listaAsignaciones = new List<Asignacion>();

            try
            {
                MySqlCommand comando = new MySqlCommand("psa_listadoAsignaciones", SQLdatos);
                comando.CommandType = CommandType.StoredProcedure;

                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    Asignacion asignacion = new Asignacion
                    {
                        idAsignacion = resultado.GetInt32("idAsignacion"),
                        id_herramienta = resultado.GetInt32("id_herramienta"),
                        id_empleado = resultado.GetInt32("id_empleado"),
                        fechaAsignacion = resultado.GetDateTime("fechaAsignacion"),
                        fechaDevolucion = resultado.GetDateTime("fechaDevolucion"),
                        activo = resultado.GetBoolean("activo")
                    };

                    listaAsignaciones.Add(asignacion);
                }

                comando.Dispose();
            }
            catch (Exception ex)
            {
                Funciones.Logs("Datos_metodoListarAsignaciones", ex.ToString());
            }
            finally
            {
                if (SQLdatos.State == ConnectionState.Open)
                {
                    SQLdatos.Close();
                }
            }

            return listaAsignaciones;
        }

        public List<Asignacion> listarAsignacionesInactivas()
        {
            MySqlConnection SQLdatos = Conexion.GetConexion().crearConexion();
            MySqlDataReader resultado;
            List<Asignacion> listaAsignaciones = new List<Asignacion>();

            try
            {
                MySqlCommand comando = new MySqlCommand("psa_listadoAsignacionesInactivas", SQLdatos);
                comando.CommandType = CommandType.StoredProcedure;

                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    Asignacion asignacion = new Asignacion
                    {
                        idAsignacion = resultado.GetInt32("idAsignacion"),
                        id_herramienta = resultado.GetInt32("id_herramienta"),
                        id_empleado = resultado.GetInt32("id_empleado"),
                        fechaAsignacion = resultado.GetDateTime("fechaAsignacion"),
                        fechaDevolucion = resultado.GetDateTime("fechaDevolucion"),
                        activo = resultado.GetBoolean("activo")
                    };

                    listaAsignaciones.Add(asignacion);
                }

                comando.Dispose();
            }
            catch (Exception ex)
            {
                Funciones.Logs("Datos_metodoListarAsignaciones", ex.ToString());
            }
            finally
            {
                if (SQLdatos.State == ConnectionState.Open)
                {
                    SQLdatos.Close();
                }
            }

            return listaAsignaciones;
        }

    }
}
