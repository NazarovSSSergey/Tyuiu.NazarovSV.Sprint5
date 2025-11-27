using Tyuiu.NazarovSV.Sprint5.Task2.V9.Lib;
namespace Tyuiu.NazarovSV.Sprint5.Task2.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mtrx = { { 6, 8, 3 }, { 2, 6, 8 }, { 1, 7, 1 } };
            int rows = mtrx.GetUpperBound(0) + 1;
            int cols = mtrx.Length / rows;
            DataService ds = new DataService();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine($"{mtrx[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            string res = ds.SaveToFileTextData(mtrx);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан успешно!");
            Console.ReadKey();
        }
    }
}
