using Tyuiu.NazarovSV.Sprint5.Task0.V8.Lib;
namespace Tyuiu.NazarovSV.Sprint5.Task0.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            DataService ss = new DataService();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Значение x равно = " + x);
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            string res = ss.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан! ");
            Console.ReadKey();
        }
    }
}
