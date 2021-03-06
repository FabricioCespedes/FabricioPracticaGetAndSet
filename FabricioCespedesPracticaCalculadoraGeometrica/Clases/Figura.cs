using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricioCespedesPracticaCalculadoraGeometrica.Clases
{
    abstract class Figura
    {
        double dato1;

        /// <summary>
        /// Constructor de la clase figura. Recibe por parámetro un double.
        /// </summary>
        /// <param name="dato1"></param>
        /// <remarks>Esto es una clase abstracta</remarks>
        protected Figura(double dato1)
        {
            this.dato1 = dato1;
        }

        /// <summary>
        /// Constructor vacio de la clase figura. No recibe parámetros.
        /// </summary>
        /// <remarks>Constructor vacio, sirve para realizar instancia vacias</remarks>
        protected Figura()
        {
        }

        /// <summary>
        /// Método que retarna el dato 1.
        /// </summary>
        /// <returns>Primer dato necesario para realizar los calculos</returns>
        /// <remarks>Método get</remarks>
        public double getDato1()
        {
            return dato1;
        }

        /// <summary>
        /// Método abstracto para ser implementado en otras clases. Recibe 3 double por parámetro.
        /// </summary>
        /// <returns>Retorna el área</returns>
        /// <remarks>Las clases hijas deben implementar este método</remarks>
        public abstract double area();

        /// <summary>
        /// Método virtual que retorna un volumen. Recibe por parámetro 3 double.
        /// </summary>
        /// <param name="divisor"></param>
        /// <returns>Retorna volumen</returns>
        /// <remarks>Este método puede ser modificado en clases hijas</remarks>
        public virtual double volumen(double divisor)
        {
            return (Math.Sqrt(2) * Math.Pow(dato1,3) / divisor);
        }
    }
}
