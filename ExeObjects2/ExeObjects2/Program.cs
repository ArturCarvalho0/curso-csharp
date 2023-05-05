using System.Globalization;

namespace ExeObjects2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario x, y;
            x = new Funcionario();
            y = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            x.nome = Console.ReadLine();
            Console.Write("Sálario: ");
            x.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            y.nome = Console.ReadLine();
            Console.Write("Sálario: ");
            y.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Salário médio = " + ((x.salario + y.salario) / 2).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}