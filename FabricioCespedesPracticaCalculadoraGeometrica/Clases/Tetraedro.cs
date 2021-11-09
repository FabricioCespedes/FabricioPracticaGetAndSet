using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricioCespedesPracticaCalculadoraGeometrica.Clases
{
    class Tetraedro:Figura
    {
        /// <summary>
        /// Constructor vacio de la clase Tetraedro.
        /// </summary>
        /// <remarks>Constructor vacio, sirve para realizar instancia vacias</remarks>
        public Tetraedro()
        {

        }


        /// <summary>
        /// Constructor Tetraedro. Recibe por parámetro 1 double (altura).
        /// </summary>
        /// <param name="altura"></param>
        /// <remarks>Sirve para crear objetos de la clase Tetraedro</remarks>
        public Tetraedro(double altura) : base(altura)
        {

        }


        /// <summary>
        /// Método que retorna el área del Tetraedro. No recibe parametros. 
        /// </summary>
        /// <returns>Método que calcula el área del Tetraedro</returns>
        public override double area()
        {
            return Math.Sqrt(3)*Math.Pow(getDato1(),2);
        }

        /// <summary>
        /// Método que retorna un string cuando el objeto es llamado.
        /// </summary>
        /// <returns>Retorna un string</returns>
        /// <remarks>Método que retorna el historial del calculo realizado</remarks>
        public override string ToString()
        {
            return "Tetraedro" + "; Altura = " + getDato1().ToString() + "; Área = " + area() + "; Volumen = " + volumen(12);
        }
    }
}
