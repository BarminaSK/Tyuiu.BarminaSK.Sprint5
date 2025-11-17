using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BarminaSK.Sprint5.Task2.V26.Lib
{
    public class DataService : ISprint5Task2V26
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            using (StreamWriter writer = new StreamWriter(path))
            {
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        int value = matrix[i, j] > 0 ? 1 : 0;

                        if (j < cols - 1)
                        {
                            writer.Write(value + ";");
                        }
                        else
                        {
                            writer.Write(value);
                        }
                    }

                    if (i < rows - 1)
                    {
                        writer.WriteLine();
                    }
                }
            }

            return path;
        }
    }
}
