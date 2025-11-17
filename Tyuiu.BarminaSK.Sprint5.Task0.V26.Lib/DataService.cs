using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BarminaSK.Sprint5.Task0.V26.Lib
{
    public class DataService : ISprint5Task0V26
    {
        public string SaveToFileTextData(int x)
        {
            double result = 0.7 * Math.Pow(x, 3) + 1.52 * Math.Pow(x, 2);
            result = Math.Round(result, 3);

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(result);
            }

            return path;

        }
    }
}
