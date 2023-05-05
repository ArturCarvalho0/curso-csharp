using System.Drawing;
using System.Globalization;

namespace ExeStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for (int i = 0;i < n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;
            Console.WriteLine(avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}