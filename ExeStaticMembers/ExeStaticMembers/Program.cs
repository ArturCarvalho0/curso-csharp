using System.Globalization;

namespace ExeStaticMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dolar;
            double quantia;
            Console.Write("Qual a cotação do dólar?");
            dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar?");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Valor a ser pago em reais = " + ConversorDeMoeda.ReaisToDolar(dolar, quantia).ToString("F2", CultureInfo.InvariantCulture));
            


        }
    }
}