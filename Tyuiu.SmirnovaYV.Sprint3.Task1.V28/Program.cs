using Tyuiu.SmirnovaYV.Sprint3.Task1.V28.Lib;
namespace Tyuiu.SmirnovaYV.Sprint3.Task1.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3| Выполнила: Смирнова Ю.В.| АСОиУБ-26-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт#3                                                                 *");
            Console.WriteLine("* Тема: оператор цикла while                                               *");
            Console.WriteLine("* Задание #1                                                               *");
            Console.WriteLine("* Вариант #28                                                              *");
            Console.WriteLine("* Выполнила: Смирнова Юлия Валерьевна | АСОиУБ-26-1                        *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу используя цикл while,                                 *");
            Console.WriteLine("* которая вычисляет сумму ряда по формуле,при a=0,5                        *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            int startValue = 1;
            int stopValue = 18;
            double value = 0.5;
            Console.WriteLine("Переменная Х = " + value);
            Console.WriteLine("Старт шага =  " + startValue);
            Console.WriteLine("Конец шага =  " + stopValue);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Результат:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value,startValue, stopValue));
            Console.ReadKey();
        }
    }
}
