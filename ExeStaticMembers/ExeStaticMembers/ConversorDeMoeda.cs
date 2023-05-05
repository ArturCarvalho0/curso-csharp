using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeStaticMembers
{
    internal class ConversorDeMoeda
    {

        public static double ReaisToDolar(double d, double q)
        {
            double valor;
            d += d * 0.06;
            valor = d * q;
            return valor;
        }
    }
}
