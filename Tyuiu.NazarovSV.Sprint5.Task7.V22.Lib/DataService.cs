using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NazarovSV.Sprint5.Task7.V22.Lib
{
    public class DataService : ISprint5Task7V22
    {
        public string LoadDataAndSave(string path)
        {
            string PSF = $@"{Path.GetTempPath()}\OutPutDataFileTask7V22.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(PSF);
            }
            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        string p = Convert.ToString(line[i]);
                        p = p.Replace(',', '#');
                        p = p.Replace('.', '#');
                        strLine += p;
                    }
                    File.AppendAllText(PSF, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return PSF;
        }
    }
}
