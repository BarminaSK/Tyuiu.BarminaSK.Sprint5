using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BarminaSK.Sprint5.Task1.V10.Lib
{
    public class DataService : ISprint5Task1V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] mass;
            int length = stopValue - startValue + 1;
            mass = new double[length];
            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = 2 * x - 1;
                if ((2 * x - 1) == 0)
                {
                    y = 0;
                }
                else
                {
                    y = ((2 * Math.Cos(x) + 2) / (2 * x - 1)) + Math.Cos(x) - 5 * x + 3;
                }
                mass[count] = Math.Round(y, 2);
                count++;
            }

            return mass;
        }

        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            double[] mass = GetMassFunction(startValue, stopValue);

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("+----------+----------+");
                writer.WriteLine("|    X     |   F(X)   |");
                writer.WriteLine("+----------+----------+");

                for (int i = 0; i < mass.Length; i++)
                {
                    int x = startValue + i;
                    writer.WriteLine($"| {x,5}    | {mass[i],8:F2} |");
                }

                writer.WriteLine("+----------+----------+");
            }

            return path;
        }
    }
}
