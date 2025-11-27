using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NazarovSV.Sprint5.Task4.V5.Lib
{
    public class DataService : ISprint5Task4V5
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x;

            if (Double.TryParse(strX, NumberStyles.Any, CultureInfo.InvariantCulture, out x))
            {
                double y = 4.26 * x / Math.Sin(x);
                y = Math.Round(y, 3);
                return y;
            }
            else
            {
                throw new FormatException($"The input string '{strX}' was not in a correct format.");
            }
        }
    }
}
