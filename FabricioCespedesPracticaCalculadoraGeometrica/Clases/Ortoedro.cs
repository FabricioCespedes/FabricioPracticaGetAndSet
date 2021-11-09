using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricioCespedesPracticaCalculadoraGeometrica.Clases
{
    class Ortoedro:Figura
    {
        double b;

        double c;

        /// <summary>
        /// Constructor vacio de la clase Ortoedro.
        /// </summary>
        /// <remarks>Constructor vacio, sirve para realizar instancia vacias</remarks>
        public Ortoedro()
        {

        }

        /// <summary>
        /// Constructor Ortoedro. Recibe por parámetro 3 double (lado a,b,c).
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <remarks>Sirve para crear objetos de la clase cubo</remarks>
        public Ortoedro(double a, double b,double c) : base(a)
        {
            this.b = b;
            this.c = c;
        }

        /// <summary>
        /// Método que retorna el lado b.
        /// </summary>
        /// <returns>Lado b del Ortoedro</returns>
        /// <remarks>Método get</remarks>
        public double getB()
        {
            return b;
        }

        /// <summary>
        /// Método que establece el lado b.
        /// </summary>
        /// <returns>Lado b del Ortoedro</returns>
        /// <remarks>Método set</remarks>
        public void setB(double b)
        {
            this.b = b;
        }

        /// <summary>
        /// Método que retorna el lado c.
        /// </summary>
        /// <returns>Lado c del Ortoedro</returns>
        /// <remarks>Método get</remarks>
        public double getC()
        {
            return c;
        }

        /// <summary>
        /// Método que establece el lado c.
        /// </summary>
        /// <returns>Lado c del Ortoedro</returns>
        /// <remarks>Método set</remarks>
        public void setC(double c)
        {
            this.c = c;
        }
        /// <summary>
        /// Método que retorna el área Ortoedro. No recibe parámetro . 
        /// </summary>
        /// <returns>Método que calcula el área del Ortoedro</returns>
        public override double area()
        {
            return 2*(getDato1()*b+ getDato1()*c+b*c) ;
        }

        /// <summary>
        /// Método que retorna el volumen Ortoedro. No recibe parámetros. 
        /// </summary>
        /// <returns>Método que calcula el volumen del Ortoedro</returns>
        public override double volumen(double dato=0)
        {
            return getDato1() * b*c;
        }

        /// <summary>
        /// Método que retorna un string cuando el objeto es llamado.
        /// </summary>
        /// <returns>Retorna un string</returns>
        /// <remarks>Método que retorna el historial del calculo realizado</remarks>
        public override string ToString()
        {
            return "Ortoedro" + "; Lado a = " + getDato1().ToString()

            + "; Lado b = " + getB().ToString()

             + "; Lado C = " + getC().ToString()

            + "; Área = " + area() + "; Volumen = " + volumen();
        }
    }
}
