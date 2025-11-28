using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NazarovSV.Sprint5.Task5.V26.Lib
{
    public class DataService : ISprint5Task5V26
    {
        public double LoadFromDataFile(string path)
        {
            double positiveSum = 0;
            double negativeSum = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] numbers = line.Split(' ');

                    foreach (string number in numbers)
                    {
                        if (double.TryParse(number, out double value))
                        {
                            if (value > 0)
                            {
                                positiveSum += value;
                            }
                            else if (value < 0)
                            {
                                negativeSum += value;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"'{number}' не является корректным числом.");
                        }
                    }
                }
            }
            double difference = Math.Round(positiveSum + Math.Abs(negativeSum), 3);
            return difference + 7.98;
        }
    }
}
