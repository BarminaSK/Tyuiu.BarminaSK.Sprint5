using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BarminaSK.Sprint5.Task3.V4.Lib
{
    public class DataService : ISprint5Task3V4
    {
        public string SaveToFileTextData(int x)
        {
            double y = Math.Log((x + 1.0) / (x + 2.0));
            y = Math.Round(y, 3);

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write(y);
            }

            return path;

        }
    }
}
