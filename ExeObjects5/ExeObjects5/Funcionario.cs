using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeObjects5
{
    internal class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido()
        {
            return (Salario - Imposto);
        }

        public void AumentarSalario(double porcentagem)
        {
            Salario += Salario*(porcentagem / 100.0) - Imposto;
        }

        public override string ToString()
        {
            return Nome+  ", $ " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
