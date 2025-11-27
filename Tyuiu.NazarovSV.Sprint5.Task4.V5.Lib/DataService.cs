using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NazarovSV.Sprint5.Task4.V5.Lib
{
    public class DataService : ISprint5Task4V5
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double y = 4.26 * Convert.ToDouble(strX) / Math.Sin(Convert.ToDouble(strX));
            y = Math.Round(y, 3);
            return y;
        }
    }
}
