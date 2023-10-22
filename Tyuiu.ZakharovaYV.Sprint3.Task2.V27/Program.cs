using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZakharovaYV.Sprint3.Task2.V27.Lib;

namespace Tyuiu.ZakharovaYV.Sprint3.Task2.V27
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
            Console.WriteLine("* Задание #2 *");
            Console.WriteLine("* Вариант #27 *");
            Console.WriteLine("* Выполнила: Захарова Юлиана Владимировна | ПКТб-23-2 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: *");
            Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет сумму *");
            Console.WriteLine("* ряда по формуле, при a = 0,5 *");
            Console.WriteLine("* *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение переменной x : ");
            int value;
            value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение начального числа");
            int startValue;
            startValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение конечного числа");
            int stopValue;
            stopValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ: *");
            Console.WriteLine("***************************************************************************");
            double Sum;
            Sum = ds.GetSumSeries(value, startValue, stopValue);
            Console.WriteLine($"Сумма ряда при x = {value} равна {Sum}");
            Console.ReadKey();
        }
    }
}
