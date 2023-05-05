using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExeObjects6
{
    internal class Aluno
    {
        public string Nome;

        public void NotaFinal(double x, double y, double z)
        {
            double soma = x + y + z;
            if (soma > 60.00)
            {
                Console.WriteLine("NOTA FINAL = "+ soma.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("NOTA FINAL = "+ soma.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + (60.00 - soma).ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}
