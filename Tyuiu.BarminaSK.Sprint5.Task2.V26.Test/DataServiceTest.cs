using System.IO;
using Tyuiu.BarminaSK.Sprint5.Task2.V26.Lib;

namespace Tyuiu.BarminaSK.Sprint5.Task2.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[3, 3]
            {
                { 2, -3, -3 },
                { -8, 8, 0 },
                { -6, 1, 0 }
            };

            string path = ds.SaveToFileTextData(matrix);

            bool fileExists = File.Exists(path);
            Assert.AreEqual(true, fileExists);

            string[] lines = File.ReadAllLines(path);

            Assert.AreEqual(3, lines.Length);
            Assert.AreEqual("1;0;0", lines[0]);
            Assert.AreEqual("0;1;0", lines[1]);
            Assert.AreEqual("0;1;0", lines[2]);
        }
    }
}
