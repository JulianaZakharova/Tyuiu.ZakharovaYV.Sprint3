using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

//На отрезке, где x принимает значения от -5 до 5, вычислить значение функции y=(cos(x)-sin(x))/x
//При х = 0 пропустить значение. Полученные значения суммировать.

namespace Tyuiu.ZakharovaYV.Sprint3.Task4.V26.Lib
{
    public class DataService : ISprint3Task4V26
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x ==0)
                {
                    break;
                }
                else
                {
                    res = res + ((Math.Cos(x) - Math.Sin(x)) / x);
                }
            }
            return Math.Round(res, 3);
        }
    }
}
