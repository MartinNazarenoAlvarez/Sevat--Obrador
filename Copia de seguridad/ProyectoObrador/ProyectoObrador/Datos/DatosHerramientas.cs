using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ProyectoObrador.Interfaz;

namespace ProyectoObrador.Datos
{
    internal class DatosHerramientas : IHerramienta
    {
        public string actualizarHerramienta(Herramienta _herramienta)
        {
            throw new NotImplementedException();
        }

        public string agregarHerramienta(Herramienta _herramienta)
        {
            MySqlConnection SQLdatos = null;
            string respuesta = "Error al guardar";
            MySqlTransaction tras = null;
            try
            {
                SQLdatos = Conexion.GetConexion().crearConexion();
                if (SQLdatos.State == ConnectionState.Closed)
                {
                    SQLdatos.Open();
                }
                tras = SQLdatos.BeginTransaction();
                MySqlCommand comando = new MySqlCommand("asp_guardar_herramienta", SQLdatos, tras)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.Add("_serial", MySqlDbType.VarChar).Value = _herramienta.numero_serie;
                comando.Parameters.Add("_nombre", MySqlDbType.VarChar).Value = _herramienta.nombre;
                comando.Parameters.Add("_descripcion", MySqlDbType.VarChar).Value = _herramienta.descripcion;
                comando.Parameters.Add("_marca", MySqlDbType.VarChar).Value = _herramienta.marca;
                comando.Parameters.Add("_modelo", MySqlDbType.VarChar).Value = _herramienta.modelo;
                comando.Parameters.Add("_estado", MySqlDbType.VarChar).Value = _herramienta.estado;

                int result = comando.ExecuteNonQuery();
                if (result == 1)
                {
                    tras.Commit();
                    respuesta = "OK";
                }
                else
                {
                    tras.Rollback();
                }
            }
            catch (Exception ex)
            {
                tras?.Rollback();
                respuesta += " - Excepcion: " + ex.Message;
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

        public Herramienta buscarXid(int _id, bool herramientasInactivosVisibles)
        {
            MySqlConnection SQLdatos = Conexion.GetConexion().crearConexion();
            MySqlDataReader resultado;
            Herramienta herramienta = null;

            try
            {
                MySqlCommand comando = new MySqlCommand("psa_buscarHerramientaXid", SQLdatos)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.AddWithValue("_id", _id);

                resultado = comando.ExecuteReader();
                if (resultado.Read())
                {
                    bool activo = resultado.GetBoolean(8);

                    if ((herramientasInactivosVisibles && !activo) || (!herramientasInactivosVisibles && activo))
                    {
                        herramienta = new Herramienta()
                        {
                            idHerramienta = resultado.GetInt32(0),
                            numero_serie = resultado.GetString(1),
                            nombre = resultado.GetString(2),
                            descripcion = resultado.GetString(3),
                            marca = resultado.GetString(4),
                            modelo = resultado.GetString(5),
                            estado = resultado.GetString(6),
                            disponible = resultado.GetBoolean(7),
                            activo = activo
                        };
                    }
                }
                resultado.Close();
            }
            catch (Exception ex)
            {
                Funciones.Logs("Datos_buscarXid", ex.ToString());
            }
            finally
            {
                if (SQLdatos.State == ConnectionState.Open)
                {
                    SQLdatos.Close();
                }
            }

            return herramienta;
        }

        public List<Herramienta> buscarXMarca(string _marca, bool herramientaActivasVisibles)
        {
            MySqlConnection SQLdatos = Conexion.GetConexion().crearConexion();
            MySqlDataReader resultado;
            List<Herramienta> herramientas = new List<Herramienta>();

            try
            {
                MySqlCommand comando = new MySqlCommand("psa_listadoHerramientasXMarca", SQLdatos)
                {
                    CommandType = CommandType.StoredProcedure
                };

                comando.Parameters.AddWithValue("_marca", _marca);
                comando.Parameters.AddWithValue("_herramientaActivasVisibles", herramientaActivasVisibles);

                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    bool activo = resultado.GetBoolean(8);
                    if (herramientaActivasVisibles || activo)
                    {
                        Herramienta herramienta = new Herramienta()
                        {
                            idHerramienta = resultado.GetInt32(0),
                            numero_serie = resultado.GetString(1),
                            nombre = resultado.GetString(2),
                            descripcion = resultado.GetString(3),
                            marca = resultado.GetString(4),
                            modelo = resultado.GetString(5),
                            estado = resultado.GetString(6),
                            disponible = resultado.GetBoolean(7),
                            activo = activo
                        };

                        herramientas.Add(herramienta);
                    }
                }
                resultado.Close();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                Funciones.Logs("Datos_BuscarXMarca", $"Error: {ex.Message} - Detalle: {ex.ToString()}");
            }
            finally
            {
                if (SQLdatos.State == ConnectionState.Open)
                {
                    SQLdatos.Close();
                }
            }

            return herramientas;
        }

        public Herramienta buscarXSerial(string _serial, bool herramientaInactivasVisibles)
        {
            MySqlConnection SQLdatos = Conexion.GetConexion().crearConexion();
            MySqlDataReader resultado;
            Herramienta herramienta = null;

            try
            {
                if (SQLdatos.State == ConnectionState.Closed)
                {
                    SQLdatos.Open();
                }

                MySqlCommand comando = new MySqlCommand("psa_listarHerramientaXSerial", SQLdatos)
                {
                    CommandType = CommandType.StoredProcedure
                };

                comando.Parameters.AddWithValue("_serial", _serial);
                //comando.Parameters.AddWithValue("_herramientaInactivasVisibles", herramientaInactivasVisibles ? 1 : 0);

                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    bool activo = resultado.GetBoolean(8);

                    if ((herramientaInactivasVisibles && !activo) || (!herramientaInactivasVisibles && activo))
                    {
                        herramienta = new Herramienta()
                        {
                            idHerramienta = resultado.GetInt32(0),
                            numero_serie = resultado.GetString(1),
                            nombre = resultado.GetString(2),
                            descripcion = resultado.GetString(3),
                            marca = resultado.GetString(4),
                            modelo = resultado.GetString(5),
                            estado = resultado.GetString(6),
                            disponible = resultado.GetBoolean(7),
                            activo = activo
                        };
                    }
                }
                resultado.Close();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                Funciones.Logs("Datos_metodoListarHerramienta", ex.ToString());
            }
            finally
            {
                if (SQLdatos.State == ConnectionState.Open)
                {
                    SQLdatos.Close();
                }
            }

            return herramienta;
        }

        public bool eliminarHerramienta(int _id)
        {
            throw new NotImplementedException();
        }

        public List<Herramienta> listarHerramientas()
        {
            MySqlConnection SQLdatos = Conexion.GetConexion().crearConexion();
            MySqlDataReader resultado;
            List<Herramienta> herramientas = new List<Herramienta>();

            try
            {
                if (SQLdatos.State == ConnectionState.Closed)
                {
                    SQLdatos.Open();
                }

                MySqlCommand comando = new MySqlCommand("psa_listadoHerramientas", SQLdatos)
                {
                    CommandType = CommandType.StoredProcedure
                };

                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    Herramienta herramienta = new Herramienta()
                    {
                        idHerramienta = resultado.GetInt32(resultado.GetOrdinal("idHerramienta")),
                        numero_serie = resultado.GetString(resultado.GetOrdinal("numero_serie")),
                        nombre = resultado.GetString(resultado.GetOrdinal("nombre")),
                        descripcion = resultado.GetString(resultado.GetOrdinal("descripcion")),
                        marca = resultado.GetString(resultado.GetOrdinal("marca")),
                        modelo = resultado.GetString(resultado.GetOrdinal("modelo")),
                        estado = resultado.GetString(resultado.GetOrdinal("estado")),
                        disponible = resultado.GetBoolean(resultado.GetOrdinal("disponible")),
                        activo = resultado.GetBoolean(resultado.GetOrdinal("activo")),
                        prestamo_activo = resultado.GetBoolean(resultado.GetOrdinal("prestamo_activo"))
                    };
                    herramientas.Add(herramienta);
                }
                resultado.Close();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                Funciones.Logs("Datos_metodoListarHerramientas", ex.ToString());
            }
            finally
            {
                if (SQLdatos.State == ConnectionState.Open)
                {
                    SQLdatos.Close();
                }
            }

            return herramientas;
        }

        //debo implementar estas funciones bien
        //
        //
        public List<Herramienta> listarHerramientasActivas()
        {
            MySqlConnection SQLdatos = Conexion.GetConexion().crearConexion();
            MySqlDataReader resultado;
            List<Herramienta> herramientas = new List<Herramienta>();

            try
            {
                MySqlCommand comando = new MySqlCommand("psa_listadoHerramientasActivas", SQLdatos)
                {
                    CommandType = CommandType.StoredProcedure
                };

                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    Herramienta herramienta = new Herramienta()
                    {
                        idHerramienta = resultado.GetInt32(0),
                        numero_serie = resultado.GetString(1),
                        nombre = resultado.GetString(2),
                        descripcion = resultado.GetString(3),
                        marca = resultado.GetString(4),
                        modelo = resultado.GetString(5),
                        estado = resultado.GetString(6),
                        disponible = resultado.GetBoolean(7),
                        activo = resultado.GetBoolean(8)
                    };
                    herramientas.Add(herramienta);
                }
                resultado.Close();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                Funciones.Logs("Datos_metodoListarHerramienta", ex.ToString());
            }
            finally
            {
                if (SQLdatos.State == ConnectionState.Open)
                {
                    SQLdatos.Close();
                }
            }
            return herramientas;
        }

        public List<Herramienta> listarHerramientasDisponibles()
        {
            MySqlConnection SQLdatos = Conexion.GetConexion().crearConexion();
            MySqlDataReader resultado;
            List<Herramienta> herramientas = new List<Herramienta>();

            try
            {
                MySqlCommand comando = new MySqlCommand("psa_listadoHerramientasDisponibles", SQLdatos)
                {
                    CommandType = CommandType.StoredProcedure
                };

                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    Herramienta herramienta = new Herramienta()
                    {
                        idHerramienta = resultado.GetInt32(0),
                        numero_serie = resultado.GetString(1),
                        nombre = resultado.GetString(2),
                        descripcion = resultado.GetString(3),
                        marca = resultado.GetString(4),
                        modelo = resultado.GetString(5),
                        estado = resultado.GetString(6),
                        disponible = resultado.GetBoolean(7),
                        activo = resultado.GetBoolean(8)
                    };

                    herramientas.Add(herramienta);
                }

                resultado.Close();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                Funciones.Logs("Datos_metodoListarHerramientasDisponibles", ex.ToString());
            }
            finally
            {
                if (SQLdatos.State == ConnectionState.Open)
                {
                    SQLdatos.Close();
                }
            }

            return herramientas;
        }

        public List<Herramienta> listarHerramientasInactivas()
        {
            MySqlConnection SQLdatos = Conexion.GetConexion().crearConexion();
            MySqlDataReader resultado;
            List<Herramienta> herramientas = new List<Herramienta>();

            try
            {
                MySqlCommand comando = new MySqlCommand("psa_listadoHerramientasInactivas", SQLdatos)
                {
                    CommandType = CommandType.StoredProcedure
                };

                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    Herramienta herramienta = new Herramienta()
                    {
                        idHerramienta = resultado.GetInt32(0),
                        numero_serie = resultado.GetString(1),
                        nombre = resultado.GetString(2),
                        descripcion = resultado.GetString(3),
                        marca = resultado.GetString(4),
                        modelo = resultado.GetString(5),
                        estado = resultado.GetString(6),
                        disponible = resultado.GetBoolean(7),
                        activo = resultado.GetBoolean(8)
                    };

                    herramientas.Add(herramienta);
                }
            }
            catch (Exception ex)
            {
                Funciones.Logs("Datos_metodoListarHerramienta", ex.ToString());
            }
            finally
            {
                if (SQLdatos.State == ConnectionState.Open)
                {
                    SQLdatos.Close();
                }
            }

            return herramientas;
        }
    }
}
