using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovJD.Sprint6.Task6.V16.Lib;

namespace Tyuiu.IvanovJD.Sprint6.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string resStr = "dsdsdw dsdsdsd";
            string line = "www dsdsdw dsdsdsd ww";
            string[] words = line.Split(' ');
            string res = "";

            foreach (string word in words)
            {
                if (word.Contains("d"))
                {
                    res += word + " ";
                }
            }
            res = res.TrimEnd();
            Assert.AreEqual(resStr, res);
        }
    }
}