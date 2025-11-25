using Tyuiu.NazarovSV.Sprint5.Task1.V5.Lib;
namespace Tyuiu.NazarovSV.Sprint5.Task1.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService sd = new DataService();
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Начало шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            string res = sd.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан! ");
            Console.ReadKey();
        }
    }
}
