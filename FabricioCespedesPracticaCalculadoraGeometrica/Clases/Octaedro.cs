using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricioCespedesPracticaCalculadoraGeometrica.Clases
{
    class Octaedro:Figura
    {
        /// <summary>
        /// Constructor vacio de la clase Cubo.
        /// </summary>
        /// <remarks>Constructor vacio, sirve para realizar instancia vacias</remarks>
        public Octaedro()
        {

        }


        /// <summary>
        /// Constructor Octaedro. Recibe por parámetro una altura de tipo double.
        /// </summary>
        /// <param name="altura"></param>
        /// <remarks>Sirve para crear objetos de la clase Octaedro</remarks>
        public Octaedro(double altura) : base(altura)
        {

        }

        /// <summary>
        /// Método que retorna el área Octaedro. Recibe altura double. 
        /// </summary>
        /// <param name="altura"></param>
        /// <returns>Método que calcula el área del Octaedro</returns>
        public override double area(double altura, double dato = 0, double dato2 = 0)
        {
            return 2* Math.Sqrt(3)*Math.Pow(altura,2);
        }

        /// <summary>
        /// Método que retorna un string cuando el objeto es llamado.
        /// </summary>
        /// <returns>Retorna un string</returns>
        /// <remarks>Método que retorna el historial del calculo realizado</remarks>
        public override string ToString()
        {
            return "Octaedro" + "Altura = " + obtenerDato1().ToString() + " Área = " + area(obtenerDato1()) + "Volumen = " + volumen(obtenerDato1());
        }
    }
}
