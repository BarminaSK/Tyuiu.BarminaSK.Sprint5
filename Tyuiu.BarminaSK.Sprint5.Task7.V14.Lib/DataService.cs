using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BarminaSK.Sprint5.Task7.V14.Lib
{
    public class DataService : ISprint5Task7V14
    {
        public string LoadDataAndSave(string path)
        {
            string inputText = File.ReadAllText(path);

            string resultText = new string(inputText.Select(c =>
            {
                if (c >= 'a' && c <= 'z')
                {
                    return char.ToUpper(c);
                }
                return c;
            }).ToArray());

            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V14.txt");

            File.WriteAllText(outputPath, resultText, Encoding.UTF8);

            return outputPath;
        }
    }
}
