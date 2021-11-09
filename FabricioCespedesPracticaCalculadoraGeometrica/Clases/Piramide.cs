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
        /// Método set and get del atributo altura de la clase piramide.
        /// </summary>
        /// <returns>La altura de la pirámide</returns>
        /// <remarks>Método get y set automaticos de c#</remarks>
        public double Altura2
        { 
            get => altura2; 
            set => altura2 = value;
        }

        /// <summary>
        /// Constructor vacio de la clase pirámide.
        /// </summary>
        /// <remarks>Constructor vacio, sirve para realizar instancia vacias</remarks>
        public Piramide()
        {
            
        }

        /// <summary>
        /// Método set and get del atributo altura de la clase piramide.
        /// </summary>
        /// <returns>La altura de la pirámide</returns>
        /// <remarks>Método get y set automaticos de c#</remarks>
        public double Altura
        {
            get => altura;
            set => altura = value;
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
        /// Método que retorna el área Piramide. No recibe parámetros. 
        /// </summary>
        /// <returns>Método que calcula el área de la pirámide</returns>
        public override double area()
        {
            return (retonarPerimetro(getDato1()) * (altura + altura2))/2 ;
        }

        /// <summary>
        /// Método que retorna el volumen Piramide.  No recibe parámetros. 
        /// </summary>
        /// <returns>Método que calcula el volumen de la pirámide</returns>
        public override double volumen(double dato2 = 0)
        {
            return (Math.Pow(getDato1(), 2)+ altura)/3;
        }

        /// <summary>
        /// Método que retorna un string cuando el objeto es llamado.
        /// </summary>
        /// <returns>Retorna un string</returns>
        /// <remarks>Método que retorna el historial del calculo realizado</remarks>
        public override string ToString()
        {
            return "; Figura: Piramide -" + "; Base = " + getDato1().ToString() + "; Altura costado = " + Altura2.ToString() + "; Altura normal = " + Altura.ToString() + "; Área = " + area() + "; Volumen = " + volumen();
        }
    }
}
