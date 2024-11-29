using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoObrador.Datos
{
    public class Asignacion
    {
        public int idAsignacion {  get; set; }
        public int id_herramienta { get; set; }
        public int id_empleado { get; set; }
        public DateTime fechaAsignacion { get; set; }
        public DateTime fechaDevolucion { get; set; }
        public bool activo {  get; set; }

        public Asignacion() { }

        public Asignacion(int idAsignacion, int id_herramienta, int id_empleado,
            DateTime fechaAsignacion, DateTime fechaDevolucion, bool activo)
        {
            this.idAsignacion = idAsignacion;
            this.id_herramienta = id_herramienta;
            this.id_empleado = id_empleado;
            this.fechaAsignacion = fechaAsignacion;
            this.fechaDevolucion = fechaDevolucion;
            this.activo = activo;
        }

        public Asignacion(int id_herramienta, int id_empleado, DateTime fechaAsignacion, 
            DateTime fechaDevolucion, bool activo)
        {
            this.id_herramienta = id_herramienta;
            this.id_empleado = id_empleado;
            this.fechaAsignacion = fechaAsignacion;
            this.fechaDevolucion = fechaDevolucion;
            this.activo = activo;
        }

    }
}
