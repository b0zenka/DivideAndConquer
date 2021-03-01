using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DivideAndConquer;

namespace UnitTestProject
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void TestProductOperatorEquals()
        {
            //testy zawierają sie z 3 rzeczy
            //dane wejściowe
            //oczekiwana wartość
            //porówninie wartości oczekiwanej

            Product productA = new Product("masełko", 0.5d, 5d);
            Product productB = new Product("pomidorek", 0.5d, 5d);

            bool result = (productA == productB);
            bool expectResult = true;

            Assert.AreEqual(expectResult, result);
        }

        [TestMethod]
        public void TestProductOperatorLessThan()
        {
            Product productA = new Product("malinka", 1d, 3d);
            Product productB = new Product("truskawka", 1d, 4d);

            bool result = (productA < productB);
            bool expectedResult = true;

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestProductOperatorMoreThan()
        {
            Product productA = new Product("malinka", 2d, 5d);
            Product productB = new Product("truskawka", 2d, 4d);

            bool result = (productA > productB);
            bool expectedResult = true;

            Assert.AreEqual(expectedResult, result);
        }
    }
}
