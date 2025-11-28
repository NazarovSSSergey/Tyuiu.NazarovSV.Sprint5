using Tyuiu.NazarovSV.Sprint5.Task7.V29.Lib;
namespace Tyuiu.NazarovSV.Sprint5.Task7.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            string path = $@"{Path.GetTempPath()}\InPutDataFileTask7V29.txt";
            string PSF = $@"{Path.GetTempPath()}\OutPutDataFileTask7V29.txt";
            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Найходится в файле: ");
            PSF = ds.LoadDataAndSave(path);
            Console.WriteLine(PSF);
            Console.ReadKey();
        }
    }
}
