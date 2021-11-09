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
        /// Método que retarno o establece la altura del cilindro.
        /// </summary>
        /// <returns>Altura del cilindro</returns>
        /// <remarks>Método get and  set</remarks>
        public double Altura 
        { 
            get => altura; 
            set => altura = value;
        }

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
        /// Método que retorna el área cilindro.No recibe parametros.
        /// </summary>
        /// <returns>Retorna el área</returns>
        /// <remarks>Método que calcula el área de un cilindro</remarks>
        public override double area()
        {
            return (2 * pi )* getDato1() * (altura+ getDato1()) ;
        }

        /// <summary>
        /// Método que retorna el volumen cilindro. No recibe parametros.
        /// </summary>
        /// <returns>Retorna el volumen</returns>
        /// <remarks>Método que calcula el volumen de un cilindro</remarks>
        public override double volumen(double dato2 = 0)
        {
            return ( pi * Math.Pow(getDato1(), 2))* altura; ;
        }

        /// <summary>
        /// Método que retorna un string cuando el objeto es llamado.
        /// </summary>
        /// <returns>Retorna un string</returns>
        /// <remarks>Método que retorna el historial</remarks>
        public override string ToString()
        {
            return "Cilindro ;" + " Radio = " + getDato1().ToString()+ "; Altura = " + Altura.ToString() + "; Área = " + area() + "; Volumen = " + volumen();
        }
    }
}
