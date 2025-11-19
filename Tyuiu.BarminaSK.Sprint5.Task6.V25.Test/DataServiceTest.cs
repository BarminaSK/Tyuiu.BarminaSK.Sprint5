using System.IO;
using Tyuiu.BarminaSK.Sprint5.Task6.V25.Lib;

namespace Tyuiu.BarminaSK.Sprint5.Task6.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V25.txt";
            int result = ds.LoadFromDataFile(path);
            int expected = 6;
            Assert.AreEqual(expected, result);
        }
    }
}
