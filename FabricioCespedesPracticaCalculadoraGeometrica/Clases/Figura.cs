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

        protected Figura(double dato1)
        {
            this.dato1 = dato1;
        }
        protected Figura()
        {
        }

        public abstract double area();
        
        public virtual double volumen(int divisor)
        {
            return (Math.Sqrt(2) * dato1) / divisor;
        }
    }
}
