using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NazarovSV.Sprint5.Task2.V9.Lib
{
    public class DataService : ISprint5Task2V9
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = $@"{Path.GetTempPath()}\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] == 7)
                    {
                        matrix[j, i] = 0;
                    }
                    if (matrix[i, j] == 1)
                    {
                        matrix[j, i] = 0;
                    }
                    if (matrix[i, j] == 3)
                    {
                        matrix[j, i] = 0;
                    }
                }
            }
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j != cols)
                    {
                        str = str +matrix[i, j] + ";";
                    }
                    else
                    {
                        str = str +matrix[i, j];
                    }
                }
                if (i != rows - 1)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }
                str = "";
            }
            return path;
        }
    }
}
