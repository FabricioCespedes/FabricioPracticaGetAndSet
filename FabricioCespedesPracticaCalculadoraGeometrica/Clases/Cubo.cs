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
        /// Método que retorna el área Cubo. Recibe el ancho double. 
        /// </summary>
        /// <param name="ancho"></param>
        /// <returns>Método que calcula el área del cubo</returns>
        public override double area(double ancho, double dato = 0, double dato2 = 0)
        {
            return 6 *  Math.Pow(ancho, 2) ;
        }

        /// <summary>
        /// Método que retorna el volumen Cubo. Recibe el ancho double. 
        /// </summary>
        /// <param name="ancho"></param>
        /// <returns>Método que calcula el volumen del cubo</returns>
        public override double volumen(double ancho, double dato1 =0, double dato2 = 0)
        {
            return  Math.Pow(ancho, 3) ;
        }

        /// <summary>
        /// Método que retorna un string cuando el objeto es llamado.
        /// </summary>
        /// <returns>Retorna un string</returns>
        /// <remarks>Método que retorna el historial del calculo realizado</remarks>
        public override string ToString()
        {
            return "Cubo," + "Ancho = " + obtenerDato1().ToString() + " Área = " + area(obtenerDato1()) + "Volumen = " + volumen(obtenerDato1());
        }
    }
}
