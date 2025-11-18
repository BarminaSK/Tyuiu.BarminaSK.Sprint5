using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BarminaSK.Sprint5.Task5.V9.Lib
{
    public class DataService : ISprint5Task5V9
    {
        public double LoadFromDataFile(string path)
        {
            string fileContent = File.ReadAllText(path);

            string[] numbers = fileContent.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int maxInt = numbers
                .Select(numStr =>
                {
                    if (double.TryParse(numStr, NumberStyles.Any, CultureInfo.InvariantCulture, out double result))
                    {
                        return result;
                    }
                    return double.MinValue;
                })
                .Where(num => num == Math.Floor(num))
                .Select(num => (int)num) 
                .Max();

            return maxInt;
        }
    }
}
