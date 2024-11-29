using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoObrador.Datos;

namespace ProyectoObrador.Interfaz
{
    internal interface IPrestamos
    {
        string agregarPrestamos(Prestamo _prestamo);
        string eliminarPrestamo(int _id);
        string actualizarPrestamo(Asignacion _asignacion, Asignacion form, bool asignacionesInactivas);

        List<Prestamo> listarPrestamo();
        List<Prestamo> buscarPrestamoPorId(int idEmpleado);
        List<Prestamo> buscarPrestamoPorFechas(DateTime fechaDesde, DateTime fechaHasta);
        List<Prestamo> buscarPrestamoPorIdYFechas(int idEmpleado, DateTime fechaDesde, DateTime fechaHasta);
    }
}
