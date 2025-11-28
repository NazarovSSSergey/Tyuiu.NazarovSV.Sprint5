using Tyuiu.NazarovSV.Sprint5.Task7.V22.Lib;
namespace Tyuiu.NazarovSV.Sprint5.Task7.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            string path = $@"{Path.GetTempPath()}\InPutDataFileTask7V22.txt";
            string path1 = $@"{Path.GetTempPath()}\OutPutDataFileTask7V22.txt";
            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Находится в файле: ");
            path1 = ds.LoadDataAndSave(path);
            Console.WriteLine(path1);
            Console.ReadKey();
        }
    }
}
