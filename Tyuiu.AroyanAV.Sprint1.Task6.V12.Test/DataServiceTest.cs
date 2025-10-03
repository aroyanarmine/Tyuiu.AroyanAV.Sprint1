using Tyuiu.AroyanAV.Sprint1.Task6.V12.Lib;

namespace Tyuiu.AroyaAV.Sprint1.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValiExpression()
        {
            DataService ds = new DataService();
            string value = "солнце светит яркое солнце";
            var res = ds.CheckLastWordRepetiton(value);
            Assert.AreEqual(res, true);
        }
    }
}