using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZakharovaYV.Sprint3.Task7.V23.Lib;

namespace Tyuiu.ZakharovaYV.Sprint3.Task7.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт#3 |Выполнила: Захарова Ю.В. |ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#3                                                                *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнила: Захарова Юлиана Владимировна | ПКТб-23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу котрая выводит таблицу значений функций              *");
            Console.WriteLine("*    4 -2x + (2+cos(x))/ 2x-2                                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: *");
            Console.WriteLine("***************************************************************************");


            int startValue = -5;
            int stopValue = 5;


           
            Console.WriteLine("Старт шага  =" + startValue);
            Console.WriteLine("Конец шага  =" + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    x     |   f(x)  |+");
            Console.WriteLine("+----------+----------+");
            for (int i = 0; i<= len-1; i++)
            {
                Console.WriteLine("| {0,5:d}  |  {1,5:f2}  |", startValue, valueArray[i]);
                startValue++;
            }

            Console.WriteLine("+----------+----------+");
            Console.ReadKey();
        }
    }
}
