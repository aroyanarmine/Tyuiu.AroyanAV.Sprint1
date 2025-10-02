using Tyuiu.AroyanAV.Sprint1.Task1.V1.Lib;

namespace Tyuiu.AroyanAV.Sprint1.Task1.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();
            double a = 1;
            double x = 27;
            double y = 3;
            var res = ds.Calculate(a, x, y);

            Assert.AreEqual(9, res);
        }
    }
}
