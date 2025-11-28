using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NazarovSV.Sprint5.Task5.V26.Lib
{
    public class DataService : ISprint5Task5V26
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            double p = 0;
            double m = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    res = res + Convert.ToDouble(line);
                }
            }
            return res;
        }
    }
}
