using System.IO;
using Tyuiu.BarminaSK.Sprint5.Task3.V4.Lib;

namespace Tyuiu.BarminaSK.Sprint5.Task3.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            int x = 3;
            string path = ds.SaveToFileTextData(x);

            bool FileExists = File.Exists(path);
            Assert.AreEqual(true, FileExists);

            double resultFromFile;
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                resultFromFile = reader.ReadDouble();
            }

            double expected = Math.Log((3 + 1)/(3 + 2));
            expected = Math.Round(expected, 3);
            Assert.AreEqual(expected, resultFromFile);

        }
    }
}
