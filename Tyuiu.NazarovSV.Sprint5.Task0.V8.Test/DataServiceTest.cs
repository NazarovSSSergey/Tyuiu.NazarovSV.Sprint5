using Tyuiu.NazarovSV.Sprint5.Task0.V8.Lib;
using System.IO;
namespace Tyuiu.NazarovSV.Sprint5.Task0.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.GetTempFileName();
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool next = true;
            Assert.AreEqual(next, fileExists);
        }
    }
}
