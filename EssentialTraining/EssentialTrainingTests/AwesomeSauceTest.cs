using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EssentialTrainingTests;

namespace EssentialTrainingTests
{
    [TestClass]
    public class AwesomeSauceTest
    {
        [TestMethod]
        public void IsSauceAwesomeTest()
        {
            var testInstance = new AwesomeSauceTest();
            testInstance.Sauces.Add("Tobasco");
            testInstance.Sauces.Add("Cholula");
            testInstance.Sauces.Add("Trailor Trash");

            //expect true
            Assert.IsTrue(testInstance.IsSauceAwesome("Trailor Trash"));

            //expect false
            Assert.IsFalse(testInstance.IsSauceAwesome("Ketchup"));
        }
    }
}
