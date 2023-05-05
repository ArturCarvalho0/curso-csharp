using System.Security.Cryptography.X509Certificates;

namespace ExeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Artur");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Add("Maria");
            list.Add("Julia");
            list.Add("Kamila");
            list.Add("Eduarda");
            list.Add("Lia");

            list.Insert(2, "Carlos");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            Console.WriteLine("--------------------");

            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach (string item in list2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------");


            list.Remove("Alex");
            foreach(string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------");


            list.RemoveAll(x => x[0] == 'M');
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------");


            list.RemoveAt(2);
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------");

            list.RemoveRange(2, 3);
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
} 