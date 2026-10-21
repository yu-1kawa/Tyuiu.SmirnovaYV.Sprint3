using Tyuiu.SmirnovaYV.Sprint3.Task0.V19.Lib;
namespace Tyuiu.SmirnovaYV.Sprint3.Task0.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds=new DataService();
            Console.Title = "Спринт #3| Выполнила: Смирнова Ю.В.| АСОиУБ-26-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт#3                                                                 *");
            Console.WriteLine("* Тема: оператор цикла for                                                 *");
            Console.WriteLine("* Задание #0                                                               *");
            Console.WriteLine("* Вариант #19                                                              *");
            Console.WriteLine("* Выполнила: Смирнова Юлия Валерьевна | АСОиУБ-26-1                        *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу используя цикл for,                                   *");
            Console.WriteLine("* которая вычисляет сумму ряда по формуле                                  *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            int startValue = 1;
            int stopValue = 10; 
            Console.WriteLine("Старт шага =  " + startValue);
            Console.WriteLine("Конец шага =  " + stopValue);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Результат:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(startValue,stopValue));
            Console.ReadKey();
        }
    }
}
