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

            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {

                        string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        string strLine = "";


                        for (int i = 0; i < words.Length; i++)
                        {
                            strLine += words[i];


                            if (words[i] == "сегодня")
                            {
                                strLine += " 12";
                            }
                            else if (words[i] == "завтра")
                            {
                                strLine += " 34";
                            }

                            if (i < words.Length - 1)
                            {
                                strLine += " ";
                            }
                        }

                        File.AppendAllText(PSF, strLine + Environment.NewLine);
                    }
                }
            }
            else
            {
                Console.WriteLine($"Файл {path} не найден.");
            }

            return PSF;
        }
    }
}
