using Tyuiu.NazarovSV.Sprint5.Task7.V29.Lib;
namespace Tyuiu.NazarovSV.Sprint5.Task7.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.GetTempFileName();
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool next = true;
            Assert.AreEqual(next, fileExists);
        }
    }
}
