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
        /// Método que retorna el área Esfera. Recibe el radio double. 
        /// </summary>
        /// <param name="radio"></param>
        /// <returns>Método que calcula el área del esfera</returns>
        public override double area(double radio, double dato = 0, double dato2 = 0)
        {
            return 4 * pi * Math.Pow(radio, 2) ;
        }

        /// <summary>
        /// Método que retorna el volumen Esfera. Recibe el radio double. 
        /// </summary>
        /// <param name="radio"></param>
        /// <returns>Método que calcula el volumen del esfera</returns>
        public override double volumen(double radio, double dato1 = 0, double dato2 = 0)
        {
            return (4 * pi * Math.Pow(radio, 3))/3; ;
        }


        /// <summary>
        /// Método que retorna un string cuando el objeto es llamado.
        /// </summary>
        /// <returns>Retorna un string</returns>
        /// <remarks>Método que retorna el historial del calculo realizado</remarks>
        public override string ToString()
        {
            return "Esfera" + "Radio = " + obtenerDato1().ToString() + " Área = " + area(obtenerDato1()) + "Volumen = " + volumen(obtenerDato1());
        }
    }
}
