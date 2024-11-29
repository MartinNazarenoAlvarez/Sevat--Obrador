using MySql.Data.MySqlClient;
using ProyectoObrador.Interfaz;
using ProyectoObrador.Vistas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoObrador.Datos
{
    internal class DatosPrestamos : IPrestamos
    {
        public string actualizarPrestamo(Asignacion _asignacion, Asignaciones form, bool asignacionesInactivas)
        {
            throw new NotImplementedException();
        }

        private bool HerramientaPrestada(int idHerramienta)
        {
            MySqlConnection SQLdatos = Conexion.GetConexion().crearConexion();
            int contador = 0;

            try
            {
                if (SQLdatos.State == ConnectionState.Closed)
                {
                    SQLdatos.Open();
                }

                MySqlCommand comando = new MySqlCommand("psa_verificar_herramienta_prestada", SQLdatos)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.AddWithValue("_id_herramienta", idHerramienta);

                contador = Convert.ToInt32(comando.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Funciones.Logs("VerificarHerra", ex.ToString());
            }
            finally
            {
                if (SQLdatos != null && SQLdatos.State == ConnectionState.Open)
                {
                    SQLdatos.Close();
                }
            }
            

            return contador > 0;
        }

        public string agregarPrestamos(Prestamo _prestamo)
        {
            bool herramientaYaPrestada = HerramientaPrestada(_prestamo.id_herramienta);

            if (herramientaYaPrestada)
            {
                return "La herramienta ya está prestada.";
            }

            MySqlConnection SQLdatos = Conexion.GetConexion().crearConexion();
            MySqlTransaction tras = null;
            string respuesta = "Error al guardar";

            try
            {
                if (SQLdatos.State == ConnectionState.Closed)
                {
                    SQLdatos.Open();
                }

                tras = SQLdatos.BeginTransaction();
                MySqlCommand comando = new MySqlCommand("asp_guardar_prestamo", SQLdatos, tras)
                {
                    CommandType = CommandType.StoredProcedure
                };

                comando.Parameters.Add("_id", MySqlDbType.Int32).Value = _prestamo.idPrestamo;
                comando.Parameters.Add("_id_herramientas", MySqlDbType.Int32).Value = _prestamo.id_herramienta;
                comando.Parameters.Add("_id_empleado", MySqlDbType.Int32).Value = _prestamo.id_empleado;
                comando.Parameters.Add("_fecha", MySqlDbType.DateTime).Value = _prestamo.fecha;
                comando.Parameters.Add("_tipo_movimiento", MySqlDbType.VarChar).Value = _prestamo.tipo_movimiento;
                comando.Parameters.Add("_cantidad", MySqlDbType.Int32).Value = _prestamo.cantidad;

                int result = comando.ExecuteNonQuery();

                if (result != 1)
                {
                    tras.Rollback();
                    return "Error al guardar el préstamo. No se pudo insertar en la base de datos.";
                }

                MySqlCommand comandoActualizar = new MySqlCommand("actualizar_estado_herramienta", SQLdatos, tras)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comandoActualizar.Parameters.AddWithValue("_id_herramienta", _prestamo.id_herramienta);

                int resultActualizar = comandoActualizar.ExecuteNonQuery();
                if (resultActualizar != 1)
                {
                    tras.Rollback();
                    return "Error al guardar el prestamo. No se pudo actualizar el estado de la herramienta.";
                }

                tras.Commit();
                respuesta = "OK";
            }
            catch (Exception ex)
            {
                Funciones.Logs("agregarPrestamos", "Rollback realizado debido a excepcion.");
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

        public List<Prestamo> buscarPrestamoPorFechas(DateTime fechaDesde, DateTime fechaHasta)
        {
            throw new NotImplementedException();
        }

        public List<Prestamo> buscarPrestamoPorId(int idEmpleado)
        {
            throw new NotImplementedException();
        }

        public List<Prestamo> buscarPrestamoPorIdYFechas(int idEmpleado, DateTime fechaDesde, DateTime fechaHasta)
        {
            throw new NotImplementedException();
        }

        public bool eliminarPrestamo(int _id)
        {
            throw new NotImplementedException();
        }

        public List<Prestamo> listarPrestamo()
        {
            MySqlConnection SQLdatos = Conexion.GetConexion().crearConexion();
            MySqlDataReader resultado;
            List<Prestamo> listaPrestamos = new List<Prestamo>();

            try
            {
                MySqlCommand comando = new MySqlCommand("psa_listadoPrestamos", SQLdatos)
                {
                    CommandType = CommandType.StoredProcedure
                };

                resultado = comando.ExecuteReader();

                while (resultado.Read())
                {
                    Prestamo prestamo = new Prestamo
                    {
                        idPrestamo = resultado.GetInt32("idPrestamo"),
                        id_herramienta = resultado.GetInt32("id_herramienta"),
                        id_empleado = resultado.GetInt32("id_empleado"),
                        fecha = resultado.GetDateTime("fecha"),
                        tipo_movimiento = resultado.GetString("tipo_movimiento"),
                        cantidad = resultado.GetInt32("cantidad"),
                        activo = resultado.GetBoolean("activo")
                    };
                    listaPrestamos.Add(prestamo);
                }

                comando.Dispose();
            }
            catch (Exception ex)
            {
                Funciones.Logs("Datos_metodoListarPrestamos", ex.ToString());
            }
            finally
            {
                if (SQLdatos.State == ConnectionState.Open)
                {
                    SQLdatos.Close();
                }
            }

            return listaPrestamos;
        }

    }
}
