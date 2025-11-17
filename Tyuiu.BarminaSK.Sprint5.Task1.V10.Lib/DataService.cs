using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BarminaSK.Sprint5.Task1.V10.Lib
{
    public class DataService : ISprint5Task1V10
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            using (StreamWriter writer = new StreamWriter(path))
            {
                double[] results = CalculateFunction(startValue, stopValue);

                for (int i = 0; i < results.Length; i++)
                {
                    double result = results[i];

                    string formattedResult;
                    if (result == 0.0)
                    {
                        formattedResult = "0";
                    }
                    else
                    {
                        formattedResult = result.ToString("F2").Replace(".", ",");
                    }

                    if (i < results.Length - 1)
                    {
                        writer.WriteLine(formattedResult);
                    }
                    else
                    {
                        writer.Write(formattedResult);
                    }
                }
            }

            return path;
        }

        public double[] CalculateFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] results = new double[length];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                try
                {
                    double denominator = 2 * x - 1;

                    if (Math.Abs(denominator) < 0.0001)
                    {
                        results[index] = 0;
                    }
                    else
                    {
                        double part1 = (2 * Math.Cos(x) + 2) / denominator;
                        double part2 = Math.Cos(x);
                        double part3 = -5 * x + 3;

                        double result = part1 + part2 + part3;
                        results[index] = Math.Round(result, 2);
                    }
                }
                catch
                {
                    results[index] = 0;
                }

                index++;
            }

            return results;
        }
    }
}
