using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoObrador.Datos
{
    class Prestamo
    {
        public int idPrestamo { get; set; }
        public int id_herramienta {  get; set; }
        public int id_empleado { get; set; }
        public DateTime fecha { get; set; }
        public string tipo_movimiento { get; set; }
        public int cantidad { get; set; }
        public bool activo {  get; set; }

        public Prestamo() { }

        public Prestamo(int idPrestamo, int id_herramienta, int id_empleado, DateTime fecha, string tipo_movimiento,
            int cantidad, bool activo)
        {
            this.idPrestamo = idPrestamo;
            this.id_herramienta = id_herramienta;
            this.id_empleado = id_empleado;
            this.fecha = fecha;
            this.tipo_movimiento = tipo_movimiento;
            this.cantidad = cantidad;
            this.activo = activo;
        }

        public Prestamo(int id_herramienta, int id_empleado, DateTime fecha, string tipo_movimiento, int cantidad,
            bool activo)
        {
            this.id_herramienta = id_herramienta;
            this.id_empleado = id_empleado;
            this.fecha = fecha;
            this.tipo_movimiento = tipo_movimiento;
            this.cantidad = cantidad;
            this.activo = activo;
        }

    }
}
