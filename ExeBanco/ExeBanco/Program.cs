using System.Globalization;

namespace ExeBanco
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Banco conta;
            


            Console.Write("Entre o número da conta: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string name = Console.ReadLine();
            Console.Write("Haverá depósito inicial(s/n): ");
            char opt = char.Parse(Console.ReadLine());


            if (opt == 'S' || opt == 's')
            {
                Console.Write("Entre o valor de depósito inicial:");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Banco(num,name,value);
            }
            else if (opt == 'N' || opt == 'n')
            {
                conta = new Banco(num, name);
            }
            else
            {
                Console.WriteLine("Digite um valor válido(s/n)");
                return;
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Despositar(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Sacar(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

        }
    }
}