using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoObrador.Datos
{
    public class Herramienta
    {
        public int idHerramienta {  get; set; }
        public string numero_serie {  get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string estado { get; set; }
        public bool disponible { get; set; }
        public bool activo { get; set; }
        public bool prestamo_activo { get; set; }

        public Herramienta() { }

        public Herramienta(int idHerramienta, string numero_serie, string nombre, string descripcion, string marca,
            string modelo, string estado, bool disponible, bool activo, bool prestamo_activo)
        {
            this.idHerramienta = idHerramienta;
            this.numero_serie = numero_serie;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.marca = marca;
            this.modelo = modelo;
            this.estado = estado;
            this.disponible = disponible;
            this.activo = activo;
            this.prestamo_activo = prestamo_activo;
        }

        public Herramienta(string numero_serie, string nombre, string descripcion, string marca, string modelo,
            string estado, bool disponible, bool activo, bool prestamo_activo)
        {
            this.numero_serie = numero_serie;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.marca = marca;
            this.modelo = modelo;
            this.estado = estado;
            this.disponible = disponible;
            this.activo = activo;
            this.prestamo_activo = prestamo_activo;
        }
    }
}
