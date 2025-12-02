using Tyuiu.NazarovSV.Sprint5.Task6.V27.Lib;
namespace Tyuiu.NazarovSV.Sprint5.Task6.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = Path.GetTempFileName();
            var res = ds.LoadFromDataFile(path);
            int next = 0;
            Assert.AreEqual(next, res);
        }
        [TestMethod]
        public void TestMethod2()
        {

            string path = Path.GetTempFileName();
            FileInfo fileInfo = new FileInfo(path);
            bool next = true;
            bool res = fileInfo.Exists;
            Assert.AreEqual(next, res);
        }
    }
}
