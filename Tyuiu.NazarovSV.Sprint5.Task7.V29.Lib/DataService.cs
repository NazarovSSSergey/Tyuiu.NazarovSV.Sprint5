using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NazarovSV.Sprint5.Task7.V29.Lib
{
    public class DataService : ISprint5Task7V29
    {
        public string LoadDataAndSave(string path)
        {
            string PSF = $@"{Path.GetTempPath()}OutPutDataFileTask7V29.txt";
            FileInfo fileInfo = new FileInfo(PSF);
            if (fileInfo.Exists)
            {
                File.Delete(PSF);
            }
            string inputFilePath = "/app/data/AssesmentData/C#/Sprint5Task7/InPutDataFileTask7V29.txt";
            if (File.Exists(inputFilePath))
            {
                using (StreamReader reader = new StreamReader(inputFilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string strLine = "";
                        for (int i = 0; i < line.Length; i++)
                        {
                            string p = Convert.ToString(line[i]);
                            if (p.Length != 1)
                            {
                                strLine += p;
                            }
                        }

                        File.AppendAllText(PSF, strLine + Environment.NewLine);
                    }
                }
            }
            else
            {
                Console.WriteLine($"Файл {inputFilePath} не найден.");
            }

            return PSF;
        }
    }
}
