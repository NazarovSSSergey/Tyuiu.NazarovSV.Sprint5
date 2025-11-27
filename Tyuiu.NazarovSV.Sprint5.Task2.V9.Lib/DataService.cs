using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NazarovSV.Sprint5.Task2.V9.Lib
{
    public class DataService : ISprint5Task2V9
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = $@"{Path.GetTempPath()}OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.GetUpperBound(1) + 1; // Исправлено: получение количества столбцов

            // Заменяем нечётные числа на нули
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0; // Исправлено: правильные индексы
                    }
                }
            }

            // Запись результата в файл
            for (int i = 0; i < rows; i++)
            {
                string str = ""; // Переместили инициализацию строки сюда
                for (int j = 0; j < cols; j++)
                {
                    str += matrix[i, j]; // Добавляем элемент массива
                    if (j < cols - 1) // Если это не последний элемент в строке
                    {
                        str += ";"; // Добавляем разделитель
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine); // Записываем строку в файл
            }

            return path;
        }
    }
}
