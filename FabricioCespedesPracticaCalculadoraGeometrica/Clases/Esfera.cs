using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricioCespedesPracticaCalculadoraGeometrica.Clases
{
    class Esfera:Figura
    {
        double pi;
        public Esfera()
        {

        }
        public Esfera(double radio) : base(radio)
        {
            pi = Math.PI;
        }


        public override double area()
        {
            double x = 0;
            return x;
        }


    }
}
