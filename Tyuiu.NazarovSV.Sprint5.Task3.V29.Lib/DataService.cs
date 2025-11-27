using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.NazarovSV.Sprint5.Task3.V29.Lib
{
    public class DataService : ISprint5Task3V29
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Path.GetTempPath()}\OutPutFileTask3.bin";
            double y = Math.Pow(x, 3) + 2 * Math.Pow(x, 2) + 5 * x + 4;
            y = Math.Round(y, 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }

            return path;
        }
    }
}