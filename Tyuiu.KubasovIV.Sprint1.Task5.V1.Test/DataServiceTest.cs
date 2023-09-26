using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KubasovIV.Sprint1.Task5.V1.Lib;
namespace Tyuiu.KubasovIV.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 2;
            double y1 = 1;
            double x2 = 4;
            double y2 = 2;
            double res = ds.DistanceBetweenDots(x1, y1, x2, y2);

            int result = Convert.ToInt32(res);
            int wait = 2;
            Assert.AreEqual(wait, result);


        }
    }
}
