using Tyuiu.AroyanAV.Sprint1.Task0.V24.Lib;

namespace Tyuiu.AroyanAV.Sprint1.Task0.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);
        }
    }
}