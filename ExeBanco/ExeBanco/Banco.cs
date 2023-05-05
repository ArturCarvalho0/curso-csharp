using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeBanco
{
    internal class Banco
    {
        public int Num { get; private set; }
        public string Nome { get; set; }
        public double Valor { get; private set; }

        public Banco(int num, string name)
        {
            Num = num;
            Nome = name;
        }

        public Banco(int num, string name, double value): this (num, name)
        {
            Valor = value;
        }

        public void Despositar(double valor)
        {
            Valor += valor;
        }

        public void Sacar(double valor)
        {
            Valor -= valor + 5.00;
           
        }

        public override string ToString()
        {
            return "Conta "+ Num + ", Titular: " + Nome + ", Saldo: $ " + Valor.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
