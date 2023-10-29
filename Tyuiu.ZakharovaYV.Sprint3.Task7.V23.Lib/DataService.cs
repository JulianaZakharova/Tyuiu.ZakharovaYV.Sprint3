using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZakharovaYV.Sprint3.Task7.V23.Lib
{
    public class DataService : ISprint3Task7V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray; // объявляется пустой массив 
            int len = (stopValue - startValue) + 1; //вычисляем длинну массива
            valueArray = new double[len];//создаем массив с указанной длинной 
            double y;
            int count = 0;
            for(int x = startValue; x<=stopValue; x++)
            {
                y = Math.Round((4 - 2 * x + ((2 + Math.Cos(x)) / 2 * x - 2)),2);// округлили до 2 знаков
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
