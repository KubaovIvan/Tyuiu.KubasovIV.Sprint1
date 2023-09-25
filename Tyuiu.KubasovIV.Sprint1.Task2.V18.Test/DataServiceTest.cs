using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KubasovIV.Sprint1.Task2.V18.Lib;

namespace Tyuiu.KubasovIV.Sprint1.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            //S = 2 (a * b + a * c + b * c)
            DataService ds = new DataService();
            int a = 6;
            int b = 5;
            int c = 3;
            var res = ds.CalculateSideSquareParallelepiped(a, b, c);
            Assert.AreEqual(126, res);
        }
    }
}
