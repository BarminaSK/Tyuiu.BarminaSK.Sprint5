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

            string path = ds.SaveToFileTextData(3);
            byte[] resultBytes = File.ReadAllBytes(path);
            double numberFromBytes = BitConverter.ToDouble(resultBytes, 0);
            double expectedNumber = -0.223;
            Assert.AreEqual(expectedNumber, numberFromBytes);

        }
    }
}
