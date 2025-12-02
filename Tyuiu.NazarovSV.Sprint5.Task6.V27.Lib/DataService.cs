using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NazarovSV.Sprint5.Task6.V27.Lib
{
    public class DataService : ISprint5Task6V27
    {
        public int LoadFromDataFile(string path)
        {
            int c = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        string[] words = line.Split(new char[] { ' ', ',', '.', ';', ':', '!', '?', '"', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string word in words)
                        {
                            if (word.Length == 3 && int.TryParse(word, out _))
                            {
                                c++;
                            }
                        }
                    }
                }
            }
            return c;
        }
    }
}
