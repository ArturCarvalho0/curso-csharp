using System.Net.WebSockets;

namespace ExeVetFix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quarto[] vet = new Quarto[10];

            Console.Write("How many rooms will be rented?");
            int qtd = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine($"Rent #{i}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                vet[room] = new Quarto(name, email);
            }

            Console.WriteLine("Busy rooms:");
            for (int i = 0; i < 10; i++)
            {
                if (vet[i] != null)
                {
                    Console.WriteLine($"{i}: {vet[i].Name}, {vet[i].Email}");
                }
            }
        }
    }
}