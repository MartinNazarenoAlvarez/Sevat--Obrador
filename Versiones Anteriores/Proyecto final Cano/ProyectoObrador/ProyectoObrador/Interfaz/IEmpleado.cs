using MySqlX.XDevAPI;
using ProyectoObrador.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoObrador.Interfaz
{
    internal interface IEmpleado
    {
        string agregarEmpleado(Empleado _empleado);
        bool eliminarEmpleado(int _id);
        string actualizarEmpleado(Empleado _empleado);
        
        Empleado buscarXid(int _id, bool empleadoInactivosVisibles);
        Empleado buscarXdni(string _dni, bool empleadoInactivosVisibles);
        DataTable listarEmpleados();
        List<Empleado> listadoXApellido(string _apellido, bool empleadoInactivosVisibles);
    }
}
