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
        /// Método que retorna el área Octaedro. No recibe parametros.
        /// </summary>
        /// <returns>Método que calcula el área del Octaedro</returns>
        public override double area()
        {
            return 2* Math.Sqrt(3)*Math.Pow(getDato1(),2);
        }

        /// <summary>
        /// Método que retorna un string cuando el objeto es llamado.
        /// </summary>
        /// <returns>Retorna un string</returns>
        /// <remarks>Método que retorna el historial del calculo realizado</remarks>
        public override string ToString()
        {
            return "Octaedro" + "; Altura = " + getDato1().ToString() + "; Área = " + area() + "; Volumen = " + volumen(3);
        }
    }
}
