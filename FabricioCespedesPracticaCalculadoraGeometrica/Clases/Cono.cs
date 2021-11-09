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
        /// Método que retorna la generatriz.
        /// </summary>
        /// <returns>generatriz del cono</returns>
        /// <remarks>Método get</remarks>
        public double getGeneratriz()
        {
            return generatriz;
        }

        /// <summary>
        /// Método que establece la generatriz.
        /// </summary>
        /// <returns>generatriz del cono</returns>
        /// <remarks>Método get</remarks>
        public void setGeneratriz(double generatriz)
        {
            this.generatriz = generatriz; ;
        }

        /// <summary>
        /// Método que retorna el radio .
        /// </summary>
        /// <returns>Radio del cono</returns>
        /// <remarks>Método get</remarks>
        public double getRadio()
        {
            return radio;
        }

        /// <summary>
        /// Método que establece el radio .
        /// </summary>
        /// <returns>Radio del cono</returns>
        /// <remarks>Método get</remarks>
        public void setRadio(double radio)
        {
            this.radio = radio;
        }

        /// <summary>
        /// Método que retorna el área Cono. No recibe parametros.
        /// </summary>
        /// <returns>Método que calcula el área del cono</returns>
        public override double area()
        {
            return pi*radio*(radio+ generatriz) ;
        }

        /// <summary>
        /// Método que retorna el volumen Cono. No recibe parametros. 
        /// </summary>
        /// <returns>Método que calcula el volumen del cono</returns>
        public override double volumen(double dato1=0)
        {
            return (pi*Math.Pow(radio,2)*getDato1())/3;
        }

        /// <summary>
        /// Método que retorna un string cuando el objeto es llamado.
        /// </summary>
        /// <returns>Retorna un string</returns>
        /// <remarks>Método que retorna el historial del calculo realizado</remarks>
        public override string ToString()
        {
            return "Cono ;" + " Altura = " + getDato1().ToString()

            + "; Generatriz = " + getGeneratriz().ToString()

             + "; Radio = " + getRadio().ToString()

            + "; Área = " + area() + "; Volumen = " + volumen();
        }
    }
}
