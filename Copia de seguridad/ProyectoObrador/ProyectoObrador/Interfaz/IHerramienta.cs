using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoObrador.Datos;

namespace ProyectoObrador.Interfaz
{
    internal interface IHerramienta
    {
        string agregarHerramienta(Herramienta _herramienta);
        bool eliminarHerramienta(int _id);
        string actualizarHerramienta(Herramienta _herramienta);

        Herramienta buscarXSerial(string _serial, bool herramientaActivasVisibles);
        Herramienta buscarXid(int _id, bool herramientasInactivosVisibles);
        List<Herramienta> buscarXMarca(string _marca, bool herramientaActivasVisibles);
        List<Herramienta> listarHerramientas();
    }
}
