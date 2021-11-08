using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricioCespedesPracticaCalculadoraGeometrica.Clases
{
    class Cono:Figura
    {
        double generatriz;
        double pi;
        double radio;

        /// <summary>
        /// Constructor vacio de la clase Cono.
        /// </summary>
        /// <remarks>Constructor vacio, sirve para realizar instancia vacias</remarks>
        public Cono()
        {

        }

        /// <summary>
        /// Constructor cono. Recibe 3 doubles por parámetro(altura,generatriz,radio).
        /// </summary>
        /// <param name="altura"></param>
        /// <param name="generatriz"></param>
        /// <param name="radio"></param>
        /// <remarks>Sirve para crear objetos de la clase cono</remarks>
        public Cono(double altura, double generatriz,double radio) : base(altura)
        {
            this.generatriz = generatriz;
            this.radio = radio;
            pi = Math.PI;
        }

        /// <summary>
        /// Método que retarna la generatriz.
        /// </summary>
        /// <returns>generatriz del cono</returns>
        /// <remarks>Método get</remarks>
        public double obtenerG()
        {
            return generatriz;
        }

        /// <summary>
        /// Método que retorna el radio .
        /// </summary>
        /// <returns>Radio del cono</returns>
        /// <remarks>Método get</remarks>
        public double obtenerRadio()
        {
            return radio;
        }

        /// <summary>
        /// Método que retorna el área Cono. Recibe 3 párametros double altura, generatriz, radio. 
        /// </summary>
        /// <param name="gene"></param>
        /// <param name="radio"></param>
        /// <param name="altura"></param>
        /// <returns>Método que calcula el área del cono</returns>
        public override double area(double gene, double radio, double altura)
        {
            return pi*radio*(radio+gene) ;
        }

        /// <summary>
        /// Método que retorna el volumen Cono. Recibe 3 párametros double altura, generatriz, radio. 
        /// </summary>
        /// <param name="gene"></param>
        /// <param name="radio"></param>
        /// <param name="altura"></param>
        /// <returns>Método que calcula el volumen del cono</returns>
        public override double volumen(double gene, double radio, double altura)
        {
            return (pi*Math.Pow(radio,2)*altura)/3;
        }

        /// <summary>
        /// Método que retorna un string cuando el objeto es llamado.
        /// </summary>
        /// <returns>Retorna un string</returns>
        /// <remarks>Método que retorna el historial del calculo realizado</remarks>
        public override string ToString()
        {
            return "Cono" + "Altura = " + obtenerDato1().ToString()

            + "Generatriz = " + obtenerG().ToString()

             + "Radio = " + obtenerRadio().ToString()

            + " Área = " + area(obtenerG(), obtenerRadio(),obtenerDato1()) + "Volumen = " + volumen(obtenerG(), obtenerRadio(), obtenerDato1());
        }
    }
}
