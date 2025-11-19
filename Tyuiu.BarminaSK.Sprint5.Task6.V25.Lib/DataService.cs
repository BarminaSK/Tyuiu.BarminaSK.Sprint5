using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BarminaSK.Sprint5.Task6.V25.Lib
{
    public class DataService : ISprint5Task6V25
    {
        public int LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            int count = text.Count(c => c == '!');
            return count;
        }
    }
}
