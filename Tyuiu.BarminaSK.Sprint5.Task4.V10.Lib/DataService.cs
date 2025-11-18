using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BarminaSK.Sprint5.Task4.V10.Lib
{
    public class DataService : ISprint5Task4V10
    {
        public double LoadFromDataFile(string path)
        {
            string FileContent = File.ReadAllText(path);
            double x = Convert.ToDouble(FileContent);

            double y = Math.Pow(x, 3) * 1.2 * x + 2;
            y = Math.Round(y, 3);

            return y;

        }
    }
}
