using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoObrador.Datos
{
    class Funciones
    {
        public static void Logs(string nombre_archivo, string detalle)
        {
            string directorio = AppDomain.CurrentDomain.BaseDirectory + "log/" + 
                DateTime.Now.Year.ToString() + "/" + 
                DateTime.Now.Month.ToString() + "/" +
                DateTime.Now.Day.ToString() + "/";

            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }

            StreamWriter mi_archivo = new StreamWriter(directorio + "/" + nombre_archivo + ".txt", true);
            string descripcion = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " --> " + detalle;

            mi_archivo.WriteLine(descripcion);
            mi_archivo.Close(); 

            //si yo quiere adeltnar en la carpeta modelo añadir los modelos para la tarea
            /*
             * para cada tabla de la base de datos es una clase
             * nombre de la clase el mismo de la tabla pero en singular, luego borrar internal
             * una vez en la class, por cada columna toca definir un atributo
             * por ejemplo tengo una columna id cliente del tipo int
             * entonces defino
             * private int idcliente{ get; set;}
             * private string apellido {get; set;}
             * y asi con todos los que tenga que hacer.
             * 
             * una clase por tabla. Tiinyint es bool. 
             * Luego crear los constructores. Tienene el nombre de la clase. por ejemplo esta seria class Cliente
             * DateTime es el equivalente en TIME.
             * 
             * Consutrcgor vacio importnate priero.
             * luego click derecho y enerar construtor con todos los parametros.
             * y otro sin el parametro sin el id cliente.o el correspondiente de la clave primaria de cada tabla.
             * 
             * 
             * public Cliente(){
             *
             * }
             * 
             * 
             * public cliente int idcleinte, string apellido
             * this.idcliente y otro mas
             * 
             * 
             * 
             * en la parte grafica, en el form hay que definir como princpla, y en la propiedades 
             * hay que definir esta propiedad en true. IsMdiContainer. Dle formulario principal lo vamos a
             * llamar, no hay que poner botones en el formulario principal importante.
             * 
             * frmCliente ventana = frmCliente()
             * 
             * ventana.Parent = this;
             * ventana.Show();
             * 
             * Los formularios van en vista.
             * */
        }
    }
}
