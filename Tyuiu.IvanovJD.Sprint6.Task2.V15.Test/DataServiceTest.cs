using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovJD.Sprint6.Task2.V15.Lib;

namespace Tyuiu.IvanovJD.Sprint6.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 70.24;
            valueWaitArray[1] = 55.47;
            valueWaitArray[2] = 41.26;
            valueWaitArray[3] = 27.76;
            valueWaitArray[4] = 13.94;
            valueWaitArray[5] = 2.67;
            valueWaitArray[6] = -13.2;
            valueWaitArray[7] = -28.53;
            valueWaitArray[8] = -43.18;
            valueWaitArray[9] = -56.75;
            valueWaitArray[10] = -69.68;


            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}