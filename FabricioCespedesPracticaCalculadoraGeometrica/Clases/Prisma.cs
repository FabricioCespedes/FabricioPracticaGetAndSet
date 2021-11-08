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
        /// Método que retorna apotema.
        /// </summary>
        /// <returns>Apotema del Prisma</returns>
        /// <remarks>Método get</remarks>
        public double obtenerApotema()
        {
            return apotema; 
        }

        /// <summary>
        /// Método que retorna el área del prisma. Recibe por parámetro 2 double (altura,apotema). 
        /// </summary>
        /// <param name="altura"></param>
        /// <param name="apotema"></param>
        /// <returns>Método que calcula el área del prisma</returns>
        public override double area(double altura, double apotema, double dato2 = 0)
        {
            return (  apotema*Math.Tan(36)*5 )* (altura + apotema) ;
        }

        /// <summary>
        /// Método que retorna el volumen del prisma. Recibe por parámetro 2 double (altura,apotema). 
        /// </summary>
        /// <param name="altura"></param>
        /// <param name="apotema"></param>
        /// <returns>Método que calcula el volumen del prisma</returns>
        public override double volumen(double altura, double apotema = 0, double dato2 = 0)
        {
            return  (((apotema * Math.Tan(36) * 5)*apotema)/2)*altura ;
        }

        /// <summary>
        /// Método que retorna un string cuando el objeto es llamado.
        /// </summary>
        /// <returns>Retorna un string</returns>
        /// <remarks>Método que retorna el historial del calculo realizado</remarks>
        public override string ToString()
        {
            return "Prisma" + "Altura = " + obtenerDato1().ToString()
                + "Apotema = " + obtenerApotema().ToString()
                + " Área = " + area(obtenerDato1(),obtenerApotema()) 
                + "Volumen = " + volumen(obtenerDato1(),obtenerApotema());
        }
    }
}
