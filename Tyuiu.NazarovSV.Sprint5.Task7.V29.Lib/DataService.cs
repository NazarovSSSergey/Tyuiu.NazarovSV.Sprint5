using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NazarovSV.Sprint5.Task7.V29.Lib
{
    public class DataService : ISprint5Task7V29
    {
        public string LoadDataAndSave(string path)
        {
            string PSF = $@"{Path.GetTempPath()}\OutPutDataFileTask7V29.txt";

            FileInfo fileInfo = new FileInfo(PSF);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(PSF);
            }
            string strLine = "";
            using (StreamReader reader = new StreamReader(PSF))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        string p = Convert.ToString(Math.Abs(line[i]));
                        if ( p.Length != 1)
                        {
                            strLine = strLine + p;
                        }
                    }

                    File.AppendAllText(PSF, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return PSF;
        }
    }
}
