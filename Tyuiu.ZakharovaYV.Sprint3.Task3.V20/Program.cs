using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZakharovaYV.Sprint3.Task3.V20.Lib;

namespace Tyuiu.ZakharovaYV.Sprint3.Task3.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт#3 |Выполнила: Захарова Ю.В. |ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#3 *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры *");
            Console.WriteLine("* Задание #3 *");
            Console.WriteLine("* Вариант #20 *");
            Console.WriteLine("* Выполнила: Захарова Юлиана Владимировна | ПКТб-23-2 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: *");
            Console.WriteLine("* Используя цикл foreach подсчитать количество букв 'f' в строке *");
            Console.WriteLine("* gfft ntf f opf *");
            Console.WriteLine("* *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: *");
            Console.WriteLine("***************************************************************************");

            char item;
            Console.WriteLine("Введите искомую букву в строке 'gfft ntf f opf' ");
            item = Convert.ToChar(Console.ReadLine());
            string value = "gfft ntf f opf";
            int count = ds.GetCharCount(value, item);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ: *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"количество найденных значений символа {item} равно {count}");
            Console.ReadKey();
        }
    }
}
