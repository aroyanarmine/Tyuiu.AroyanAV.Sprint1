using Tyuiu.AroyanAV.Sprint1.Task2.V26.Lib;

namespace Tyuiu.AroyanAV.Sprint1.Task2.V26.Test;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void CalendarCheck()
    {
        DataService ds = new DataService();
        int value = 7;
        int valueTwo = 15;
        var res = ds.CalculateMinutesSinceStart(value, valueTwo);
        Assert.AreEqual(435, res);
    }
}