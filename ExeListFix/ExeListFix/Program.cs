using System.Globalization;
using System.Runtime.CompilerServices;

namespace ExeListFix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employess will be registered? ");
            int qtd = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine($"Employee #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees.Add(new Employee(id, name, salary));
            }

            Console.WriteLine("Enter the employe id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());


            Employee emp = employees.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double prc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(prc);

            }
            else { 
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("Updated list of employees: ");
            foreach (Employee item in employees)
            {
                Console.WriteLine($"{item.Id}, {item.Name}, {item.Salary}");

            }
        }
    }
}