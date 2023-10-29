using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZakharovaYV.Sprint3.Task4.V26.Lib;

namespace Tyuiu.ZakharovaYV.Sprint3.Task4.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт#3 |Выполнила: Захарова Ю.В. |ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#3                                                                *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнила: Захарова Юлиана Владимировна | ПКТб-23-2                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: На отрезке, где x принимает значения от -5 до 5, вычислить     *");
            Console.WriteLine("*  значение функции y=(cos(x)-sin(x))/x                                   *");
            Console.WriteLine("* При х = 0 пропустить значение.Полученные значения суммировать.          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ: *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Сумма ряда = " + ds.Calculate(startValue, stopValue));

            Console.ReadKey();
        }
    }
}
