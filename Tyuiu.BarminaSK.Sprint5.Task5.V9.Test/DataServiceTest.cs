using System.IO;
using Tyuiu.BarminaSK.Sprint5.Task5.V9.Lib;

namespace Tyuiu.BarminaSK.Sprint5.Task5.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask5V9.txt";
            double result = ds.LoadFromDataFile(path);
            double expected = 17;

            Assert.AreEqual(expected, result);
        }
    }
}
