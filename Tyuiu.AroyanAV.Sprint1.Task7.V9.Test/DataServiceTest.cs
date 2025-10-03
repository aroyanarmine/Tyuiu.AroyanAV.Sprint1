using Tyuiu.AroyanAV.Sprint1.Task7.V9.Lib;

namespace Tyuiu.AroyanAV.Sprint1.Task7.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            double wait = 6.633;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}