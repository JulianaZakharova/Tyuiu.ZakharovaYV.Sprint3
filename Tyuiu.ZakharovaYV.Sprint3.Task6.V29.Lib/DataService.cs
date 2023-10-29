using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;
//Напишите программу, которая ищет среди целых чисел, принадлежащих числовому отрезку [12, 18] сумму всех делителей
//Название проектов(консольного приложения, библиотеки классов, тестового модуля) оформить по шаблону в соответствии с вариантом.
//Интерфейс консольного приложения оформить по шаблону. 

namespace Tyuiu.ZakharovaYV.Sprint3.Task6.V29.Lib
{
    public class DataService : ISprint3Task6V29
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x;
            int sum = 0;
            for (x = startValue; x <= stopValue; x++)
            {
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        sum += d;
                    }    
                }
            }
            return sum;
        }
    }
}
