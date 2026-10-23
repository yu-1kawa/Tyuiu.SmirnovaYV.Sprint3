using Tyuiu.SmirnovaYV.Sprint3.Task3.V9.Lib;
namespace Tyuiu.SmirnovaYV.Sprint3.Task3.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3| Выполнила: Смирнова Ю.В.| АСОиУБ-26-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт#3                                                                 *");
            Console.WriteLine("* Тема: оператор цикла foreach                                             *");
            Console.WriteLine("* Задание #3                                                               *");
            Console.WriteLine("* Вариант #9                                                               *");
            Console.WriteLine("* Выполнила: Смирнова Юлия Валерьевна | АСОиУБ-26-1                        *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Используя цикл foreach заменить цифры на букву w                         *");
            Console.WriteLine("* в строке: 56hy vfe4r4 vf45b                                             *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            string value = "56hy vfe4r4 vf45b";
            char chr = 'w';
            Console.WriteLine("Исходная строка =  " + value);
            Console.WriteLine("Искомый символ =  " + chr);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Результат:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Количество символов = " + ds.ReplaceNumOnChar(value, chr));
            Console.ReadKey();
        }
    }
}
