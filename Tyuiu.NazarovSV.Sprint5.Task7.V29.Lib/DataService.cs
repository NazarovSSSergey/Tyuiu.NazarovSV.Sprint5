using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.NazarovSV.Sprint5.Task7.V29.Lib
{
    public class DataService : ISprint5Task7V29
    {
        public string LoadDataAndSave(string path)
        {
            string PSF = $@"{Path.GetTempPath()}\OutPutFileTask7V29";
            FileInfo fileInfo = new FileInfo(PSF);
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
                        string p = Convert.ToString(Math.Abs(line[i]));
                        if (p.Length != 1)
                        {
                            strLine = strLine + p;
                        }
                    }
                }
                File.AppendAllText(PSF, strLine + Environment.NewLine);
                strLine = "";
            }
            return PSF;
        }
    }
}
