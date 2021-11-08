using FabricioCespedesPracticaCalculadoraGeometrica.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricioCespedesPracticaCalculadoraGeometrica.Modelo
{
    class Logica
    {
        static List<Figura> listaHistorial = new List<Figura>();

        public List<Figura> devolverLista()
        {
            return listaHistorial;
        }

        public void ingresarHistorial(Figura figura)
        {
            listaHistorial.Add(figura);
        }
    }
}
