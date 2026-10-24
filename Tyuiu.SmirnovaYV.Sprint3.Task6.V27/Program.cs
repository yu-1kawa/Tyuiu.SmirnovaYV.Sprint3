using Tyuiu.SmirnovaYV.Sprint3.Task6.V27.Lib;
namespace Tyuiu.SmirnovaYV.Sprint3.Task6.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3| Выполнила: Смирнова Ю.В.| АСОиУБ-26-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт#3                                                                 *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                 *");
            Console.WriteLine("* Задание #6                                                               *");
            Console.WriteLine("* Вариант #27                                                              *");
            Console.WriteLine("* Выполнила: Смирнова Юлия Валерьевна | АСОиУБ-26-1                        *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел,                      *");
            Console.WriteLine("* принадлежащих числовому отрезку [14, 20] сумму всех делителей больше 9   *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            int startValue = 14;
            int stopValue = 20;
            
            Console.WriteLine("Начало отрезка =  " + startValue);
            Console.WriteLine("Конец отрезка =  " + stopValue);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Результат:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Сумма ряда = " + ds.GetSumTheDivisors(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
