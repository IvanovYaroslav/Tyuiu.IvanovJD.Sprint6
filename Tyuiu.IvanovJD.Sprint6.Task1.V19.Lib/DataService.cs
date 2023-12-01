﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.IvanovJD.Sprint6.Task1.V19.Lib
{
    public class DataService : ISprint6Task1V19
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int cnt = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = (Math.Cos(x) + (Math.Cos(x)/(x + 2)) - 3 * x);
                y = Math.Round(y, 2);
                valueArray[3] = 0;
                valueArray[cnt] = y;
                cnt++;
            }

            return valueArray;
        }
    }
}