using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricioCespedesPracticaCalculadoraGeometrica.Clases
{
    class Piramide:Figura
    {
        double altura;

        double altura2;

        /// <summary>
        /// Constructor vacio de la clase pirámide.
        /// </summary>
        /// <remarks>Constructor vacio, sirve para realizar instancia vacias</remarks>
        public Piramide()
        {
            
        }

        /// <summary>
        /// Método que retorna la altura.
        /// </summary>
        /// <returns>La altura de la pirámide</returns>
        /// <remarks>Método get</remarks>
        public double obtenerAltura()
        {
            return altura;
        }

        /// <summary>
        /// Método que retorna la segunda altura.
        /// </summary>
        /// <returns>La segunda altura de la pirámide</returns>
        /// <remarks>Método get</remarks>
        public double obtenerAltura2()
        {
            return altura2;
        }

        /// <summary>
        /// Constructor pirámide. Recibe por parámetro double (altura, base, segunda altura).
        /// </summary>
        /// <param name="basePiram"></param>
        /// <param name="altu"></param>
        /// <param name="altu2"></param>
        /// <remarks>Sirve para crear objetos de la clase pirámide</remarks>
        public Piramide(double basePiram, double altu,  double altu2) : base(basePiram)
        {
            altura = altu;
            altura2 = altu2;
        }

        /// <summary>
        /// Método que retorna el perímetro de la pirámide
        /// </summary>
        /// <param name="basePiram"></param>
        /// <returns></returns>
        public double retonarPerimetro(double basePiram)
        {
            return basePiram * 4;
        }

        /// <summary>
        /// Método que retorna el área Piramide. Recibe por parámetro double (altura, base, segunda altura) 
        /// </summary>
        /// <param name="basePiram"></param>
        /// <param name="altu"></param>
        /// <param name="altu2"></param>
        /// <returns>Método que calcula el área de la pirámide</returns>
        public override double area(double altura, double basePiram, double altura2)
        {
            return (retonarPerimetro(basePiram) * (altura + altura2))/2 ;
        }

        /// <summary>
        /// Método que retorna el volumen Piramide. Recibe por parámetro double (altura, base, segunda altura) 
        /// </summary>
        /// <param name="basePiram"></param>
        /// <param name="altu"></param>
        /// <param name="altu2"></param>
        /// <returns>Método que calcula el volumen de la pirámide</returns>
        public override double volumen(double altura, double basePiram, double dato2 = 0)
        {
            return (Math.Pow(basePiram, 2)+ altura)/3;
        }

        /// <summary>
        /// Método que retorna un string cuando el objeto es llamado.
        /// </summary>
        /// <returns>Retorna un string</returns>
        /// <remarks>Método que retorna el historial del calculo realizado</remarks>
        public override string ToString()
        {
            return "Figura: Piramide -" + " Base = " + obtenerDato1().ToString() + " Altura costador = " + obtenerAltura2().ToString() + " Altura normal = " + obtenerAltura().ToString() + " Área = " + area(obtenerDato1(),obtenerAltura(),obtenerAltura2()) + "Volumen = " + volumen(obtenerAltura(),obtenerDato1());
        }
    }
}
