using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricioCespedesPracticaCalculadoraGeometrica.Clases
{
    class Cubo:Figura
    {
        double pi;


        /// <summary>
        /// Constructor vacio de la clase Cubo.
        /// </summary>
        /// <remarks>Constructor vacio, sirve para realizar instancia vacias</remarks>
        public Cubo()
        {

        }

        /// <summary>
        /// Constructor cubo. Recibe por parámetro un ancho de tipo double.
        /// </summary>
        /// <param name="ancho"></param>
        /// <remarks>Sirve para crear objetos de la clase cubo</remarks>
        public Cubo(double ancho) : base(ancho)
        {
            pi = Math.PI;
        }

        /// <summary>
        /// Método que retorna el área Cubo. No recibe parametros.
        /// </summary>
        /// <returns>Método que calcula el área del cubo</returns>
        public override double area()
        {
            return 6 *  Math.Pow(getDato1(), 2) ;
        }

        /// <summary>
        /// Método que retorna el volumen Cubo. No recibe parametros.
        /// </summary>
        /// <param name="ancho"></param>
        /// <returns>Método que calcula el volumen del cubo</returns>
        public override double volumen(double dato2 = 0)
        {
            return  Math.Pow(getDato1(), 3) ;
        }

        /// <summary>
        /// Método que retorna un string cuando el objeto es llamado.
        /// </summary>
        /// <returns>Retorna un string</returns>
        /// <remarks>Método que retorna el historial del calculo realizado</remarks>
        public override string ToString()
        {
            return "Cubo ," + " Ancho = " + getDato1().ToString() + "; Área = " + area() + "; Volumen = " + volumen();
        }
    }
}
