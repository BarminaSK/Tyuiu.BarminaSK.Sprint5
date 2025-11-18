using System.IO;
using Tyuiu.BarminaSK.Sprint5.Task4.V10.Lib;

namespace Tyuiu.BarminaSK.Sprint5.Task4.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask4V10.txt";
            double result = ds.LoadFromDataFile(path);

            double x = 2.74;
            double expected = Math.Pow(x, 3) * 1.2 * x + 2;
            expected = Math.Round(expected, 3);

            Assert.AreEqual(expected, result);
        }
    }
}
