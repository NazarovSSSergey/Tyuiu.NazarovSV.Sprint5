using System.Numerics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string outputFile = "OutPutFileTask0.txt";
            double x5 = -2;
            double result5 = 3 * Math.Pow(x5, 3) + 4 * Math.Pow(x5, 2) - 2 * x5 + 7;
            File.AppendAllText(outputFile, result5.ToString());
            Console.WriteLine(result5);
        }
    }
}
