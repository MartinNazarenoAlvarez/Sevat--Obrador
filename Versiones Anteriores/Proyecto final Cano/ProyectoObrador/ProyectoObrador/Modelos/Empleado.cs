using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoObrador.Datos
{
    public class Empleado
    { //id empelado, aepllido, nombre, cargo, telefono, activo
        public int idEmpleado { get; set; }
        public string dni { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public string cargo { get; set; }
        public string telefono {  get; set; }
        public bool activo { get; set; }


        public Empleado() { }

        public Empleado(int idEmpleado, string dni, string apellido, string nombre,
            string cargo, string telefono, bool activo)
        {
            this.idEmpleado = idEmpleado;
            this.dni = dni;
            this.apellido = apellido;
            this.nombre = nombre;
            this.cargo = cargo;
            this.telefono = telefono;
            this.activo = activo;
        }

        public Empleado(string dni, string apellido, string nombre, string cargo, 
            string telefono, bool activo)
        {
            this.dni = dni;
            this.apellido = apellido;
            this.nombre = nombre;
            this.cargo = cargo;
            this.telefono = telefono;
            this.activo = activo;
        }

    }
}
