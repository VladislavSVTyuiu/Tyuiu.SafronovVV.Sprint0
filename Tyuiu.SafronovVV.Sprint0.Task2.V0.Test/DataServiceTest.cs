using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SafronovVV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.SafronovVV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Влад";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Влад", res);
        }
    }
}
