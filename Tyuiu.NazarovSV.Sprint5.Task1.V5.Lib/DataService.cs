using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NazarovSV.Sprint5.Task1.V5.Lib
{
    public class DataService : ISprint5Task1V5
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Path.GetTempPath()}\OutPutFileTask1";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            double y;
            string sY;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ( 2*x - 0.5 != 0)
                {
                    y = 5 - 3 * x + ((1 + Math.Sin(x)) / (2 * x - 0.5));
                    y = Math.Round(y, 2);
                    sY = Convert.ToString(y);
                    if (x != stopValue)
                    {
                        File.AppendAllText(path, sY + Environment.NewLine);
                    }
                    else
                    {
                        File.AppendAllText(path, sY);
                    }
                }
                if ( 2*x - 0.5 == 0 )
                {
                    y = 0;
                    sY = Convert.ToString(y);
                    if (x != stopValue)
                    {
                        File.AppendAllText(path, sY + Environment.NewLine);
                    }
                    else
                    {
                        File.AppendAllText(path, sY);
                    }
                }
            }
            return path;
        }
    }
}
