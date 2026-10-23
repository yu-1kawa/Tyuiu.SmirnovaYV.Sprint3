using Tyuiu.SmirnovaYV.Sprint3.Task4.V23.Lib;
namespace Tyuiu.SmirnovaYV.Sprint3.Task4.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds=new DataService();
            int startValue = -5;
            int endValue = 5;
            double res= ds.Calculate(startValue, endValue);
            double wait = 244.656;
            Assert.AreEqual(wait, res);
        }
    }
}
