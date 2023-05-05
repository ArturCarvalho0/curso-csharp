using System.Globalization;

namespace ExeObjects6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            double x, y, z;

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.NotaFinal(x, y, z);

        }
    }
}