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
        /// Método que retorna el área del Tetraedro. Recibe por parámetro double (altura). 
        /// </summary>
        /// <param name="altura"></param>
        /// <returns>Método que calcula el área del Tetraedro</returns>
        public override double area(double altura, double dato = 0, double dato2 = 0)
        {
            return Math.Sqrt(3)*Math.Pow(altura,2);
        }

        /// <summary>
        /// Método que retorna un string cuando el objeto es llamado.
        /// </summary>
        /// <returns>Retorna un string</returns>
        /// <remarks>Método que retorna el historial del calculo realizado</remarks>
        public override string ToString()
        {
            return "Tetraedro" + "Altura = " + obtenerDato1().ToString() + " Área = " + area(obtenerDato1()) + "Volumen = " + volumen(obtenerDato1());
        }
    }
}
