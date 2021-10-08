using System;
using System.Collections.Generic;
using System.Text;

namespace ExaBimIV
{
    class Pecera
    {
        private double galones = 0;
        private double litros = 0;

        public void CalculoLitros(double largo, double ancho, double alto)
        {
            litros = largo * ancho * largo;
        }

        public double VerLitros()
        {
            return litros;
        }

        public double CalculoGalones()
        { 
        
        }
    }
}
