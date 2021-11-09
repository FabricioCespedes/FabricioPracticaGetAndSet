using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricioCespedesPracticaCalculadoraGeometrica.Clases
{
    class Esfera:Figura
    {
        double pi;

        /// <summary>
        /// Constructor vacio de la clase esfera.
        /// </summary>
        /// <remarks>Constructor vacio, sirve para realizar instancia vacias</remarks>
        public Esfera()
        {

        }

        /// <summary>
        /// Constructor esfera. Recibe por parámetro un radio de tipo double.
        /// </summary>
        /// <param name="radio"></param>
        /// <remarks>Sirve para crear objetos de la clase esfera</remarks>
        public Esfera(double radio) : base(radio)
        {
            pi = Math.PI;
        }

        /// <summary>
        /// Método que retorna el área Esfera. No recibe parametros. 
        /// </summary>
        /// <returns>Método que calcula el área del esfera</returns>
        public override double area()
        {
            return 4 * pi * Math.Pow(getDato1(), 2) ;
        }

        /// <summary>
        /// Método que retorna el volumen Esfera. No recibe parametros. 
        /// </summary>
        /// <returns>Método que calcula el volumen del esfera</returns>
        public override double volumen(double dato2 = 0)
        {
            return (4 * pi * Math.Pow(getDato1(), 3))/3; ;
        }


        /// <summary>
        /// Método que retorna un string cuando el objeto es llamado.
        /// </summary>
        /// <returns>Retorna un string</returns>
        /// <remarks>Método que retorna el historial del calculo realizado</remarks>
        public override string ToString()
        {
            return "Esfera" + "; Radio = " + getDato1().ToString() + "; Área = " + area() + "; Volumen = " + volumen();
        }
    }
}
