using ProyectoObrador.Datos;
using ProyectoObrador.Vistas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoObrador.Interfaz
{
    internal interface IAsignacion
    {
        string agregarAsignacion(Asignacion _asignacion);
        bool eliminarAsignacion(int _id);
        string actualizarAsignacion(Asignacion _asignacion, Asignaciones form, bool asignacionesInactivas);
        
        List<Asignacion> buscarAsignacionPorId(int idEmpleado);
        List<Asignacion> buscarAsignacionPorFechas(DateTime fechaDesde, DateTime fechaHasta);
        List<Asignacion> buscarAsignacionPorIdYFechas(int idEmpleado, DateTime fechaDesde, DateTime fechaHasta);
    }
}
