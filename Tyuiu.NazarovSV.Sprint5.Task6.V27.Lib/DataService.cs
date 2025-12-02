using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NazarovSV.Sprint5.Task6.V27.Lib
{
    public class DataService : ISprint5Task6V27
    {
        public int LoadFromDataFile(string path)
        {
            int co = 0;
            string number = "";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    foreach (char c in line)
                    {
                        if (char.IsDigit(c))
                        {
                            number += c;
                        }
                        else
                        {
                            if (number.Length == 3)
                            {
                                co++;
                            }
                            number = "";
                        }
                    }
                    if (number.Length == 3)
                    {
                        co++;
                    }
                    number = "";
                }
            }
            return co;
        }
    }
}
