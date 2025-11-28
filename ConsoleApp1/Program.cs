using System.Numerics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string content = File.ReadAllText("C:\\Users\\79136\\source\\repos\\Tyuiu.NazarovSV.Sprint5\\ConsoleApp1\bin\Debug\net8.0\a(3).txt");
            string newContent = "";
            foreach (char c in content)
            {
                if (!char.IsUpper(c))
                {
                    newContent += c;
                }
            }
            File.WriteAllText("a(3).txt", newContent);
            Console.WriteLine(String.Join("\n", newContent));
        }
    }
}
