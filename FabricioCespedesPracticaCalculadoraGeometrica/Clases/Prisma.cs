using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricioCespedesPracticaCalculadoraGeometrica.Clases
{
    class Prisma:Figura
    {
        double apotema;

        /// <summary>
        /// Método que retorna y establece la apotema de la clase Prisma.
        /// </summary>
        /// <returns>Apotema del Prisma</returns>
        /// <remarks>Método get y set</remarks>
        public double Apotema 
        { 
            get => apotema; 
            set => apotema = value; 
        }

        /// <summary>
        /// Constructor vacio de la clase Prisma.
        /// </summary>
        /// <remarks>Constructor vacio, sirve para realizar instancia vacias</remarks>
        public Prisma()
        {

        }

        /// <summary>
        /// Constructor Prisma. Recibe por parámetro 2 double (altura,apotema).
        /// </summary>
        /// <param name="altura"></param>
        /// <param name="apotema"></param>
        /// <remarks>Sirve para crear objetos de la clase Prisma</remarks>
        public Prisma(double altura,double apotema) : base(altura)
        {
            this.apotema = apotema;
        }




        /// <summary>
        /// Método que retorna el área del prisma. Recibe por parámetro 2 double (altura,apotema). 
        /// </summary>
        /// <param name="altura"></param>
        /// <param name="apotema"></param>
        /// <returns>Método que calcula el área del prisma</returns>
        public override double area()
        {
            return (  apotema*Math.Tan(36)*5 )* (getDato1() + apotema) ;
        }

        /// <summary>
        /// Método que retorna el volumen del prisma. Recibe por parámetro 2 double (altura,apotema). 
        /// </summary>
        /// <param name="altura"></param>
        /// <param name="apotema"></param>
        /// <returns>Método que calcula el volumen del prisma</returns>
        public override double volumen(double dato2 = 0)
        {
            return  (((apotema * Math.Tan(36) * 5)*apotema)/2)* getDato1();
        }

        /// <summary>
        /// Método que retorna un string cuando el objeto es llamado.
        /// </summary>
        /// <returns>Retorna un string</returns>
        /// <remarks>Método que retorna el historial del calculo realizado</remarks>
        public override string ToString()
        {
            return "Prisma" + "; Altura = " + getDato1().ToString()
                + "; Apotema = " + Apotema.ToString()
                + "; Área = " + area() 
                + "; Volumen = " + volumen();
        }
    }
}
