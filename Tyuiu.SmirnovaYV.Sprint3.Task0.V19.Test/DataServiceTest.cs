using Tyuiu.SmirnovaYV.Sprint3.Task0.V19.Lib;
namespace Tyuiu.SmirnovaYV.Sprint3.Task0.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds= new DataService();
            int startValue = 1;
            int endValue = 10;
            double res= ds.GetSumSeries(startValue, endValue);
            double wait = 4.399;
            Assert.AreEqual(wait, res);
        }
    }
}
