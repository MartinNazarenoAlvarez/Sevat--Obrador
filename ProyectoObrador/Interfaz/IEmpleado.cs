using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoObrador.Datos;

namespace ProyectoObrador.Interfaz
{
    internal interface IEmpleado
    {
        string agregarEmpleado(Empleado _empleado);
        string eliminarEmpleado(string dni);
        string actualizarEmpleado(Empleado _empleado, string dniOriginal, string dniNuevo);

        Empleado buscarXid(int _id, bool empleadoInactivosVisibles);
        Empleado buscarXdni(string _dni, bool empleadoInactivosVisibles);
        List<Empleado> listarEmpleados();
        List<Empleado> listadoXApellido(string _apellido, bool empleadoInactivosVisibles);
        List<Empleado> listarEmpleadosActivos();
        List<Empleado> listarEmpleadosInactivos();

    }
}
