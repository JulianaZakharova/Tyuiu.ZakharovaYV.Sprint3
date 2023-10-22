using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZakharovaYV.Sprint3.Task2.V27.Lib
{
    public class DataService : ISprint3Task2V27
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double Sum = 0;
            do
            {
                Sum = Sum + Math.Pow(4 / (1 + Math.Pow(value, startValue)), startValue);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(Sum, 3);

        }
    }
}
