using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SmirnovaYV.Sprint3.Task2.V5.Lib
{
    public class DataService : ISprint3Task2V5
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double SumSeries = 0;
            int k=startValue;
            do
            {
                SumSeries = SumSeries + (Math.Pow(value, k) + 1) * Math.Cos(k);
                k++;
            }
            while (k <= stopValue);
            return Math.Round(SumSeries, 3);
        }
    }
}
