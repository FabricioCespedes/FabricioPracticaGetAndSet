using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricioCespedesPracticaCalculadoraGeometrica.Clases
{
    class Cilindro:Figura
    {
        double pi;

        double altura;

        /// <summary>
        /// Constructor vacio de la clase cilindro.
        /// </summary>
        /// <remarks>Constructor vacio, sirve para realizar instancia vacias</remarks>
        public Cilindro()
        {

        }
        /// <summary>
        /// Constructor cilindro. Recibe 2 doubles por parámetro.
        /// </summary>
        /// <param name="radio"></param>
        /// <param name="altura"></param>
        /// <remarks>Sirve para crear objetos de la clase Cilindro</remarks>
        public Cilindro(double radio, double altura) : base(radio)
        {
            pi = Math.PI;

            this.altura = altura;
        }

        /// <summary>
        /// Método que retarna la altura.
        /// </summary>
        /// <returns>Altura del cilindro</returns>
        /// <remarks>Método get</remarks>
        public double retornarAltura()
        {
            return altura;
        }

        /// <summary>
        /// Método que retorna el área cilindro. Recibe 2 párametros double el radio y altura .
        /// </summary>
        /// <param name="radio"></param>
        /// <param name="altura"></param>
        /// <param name="dato2"></param>
        /// <returns>Retorna el área</returns>
        /// <remarks>Método que calcula el área de un cilindro</remarks>
        public override double area(double radio, double altura, double dato2 = 0)
        {
            return (2 * pi )* radio*(altura+ radio) ;
        }

        /// <summary>
        /// Método que retorna el volumen cilindro. Recibe 2 párametros double el radio y altura .
        /// </summary>
        /// <param name="radio"></param>
        /// <param name="altura"></param>
        /// <param name="dato2"></param>
        /// <returns>Retorna el volumen</returns>
        /// <remarks>Método que calcula el volumen de un cilindro</remarks>
        public override double volumen(double radio, double altura, double dato2 = 0)
        {
            return ( pi * Math.Pow(radio, 2))* altura; ;
        }

        /// <summary>
        /// Método que retorna un string cuando el objeto es llamado.
        /// </summary>
        /// <returns>Retorna un string</returns>
        /// <remarks>Método que retorna el historial</remarks>
        public override string ToString()
        {
            return "Cilindro ;" + "Radio = " + obtenerDato1().ToString()+ "Altura = " + retornarAltura().ToString() + " Área = " + area(obtenerDato1(), retornarAltura()) + "Volumen = " + volumen(obtenerDato1(), retornarAltura());
        }
    }
}
