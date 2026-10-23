using System.Text;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SmirnovaYV.Sprint3.Task3.V9.Lib
{
    public class DataService : ISprint3Task3V9
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            StringBuilder sb= new StringBuilder();
            foreach(char c in value)
            {
                if (char.IsDigit(c))
                {
                    sb.Append(item);
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}
