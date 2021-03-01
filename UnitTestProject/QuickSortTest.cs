using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DivideAndConquer;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class QuickSortTest
    {
        [TestMethod]
        public void TestQuickSortInts()
        {
            int[] tab = new int[] { 10, 5, 6, 4, 3 };
            int[] resultTab = QuickSort<int>.Sort(tab);
            int[] expectedTab = new[] { 3, 4, 5, 6, 10 };
            Assert.IsTrue(Enumerable.SequenceEqual(resultTab, expectedTab));
        }

        [TestMethod]
        public void TestQuickSortProducts()
        {
            Product[] productTable = new Product[] { new Product("jogurt", 0.2d, 3d),
                                                    new Product("margaryna", 0.5d, 3d),
                                                    new Product("masło", 0.5d, 5d),
                                                    new Product("kefir", 0.2d, 5d)};
            QuickSort<Product>.Sort(productTable);

            Product[] productExpectedTable = new Product[] { new Product("margaryna", 0.5d, 3d),
                                                    new Product("masło", 0.5d, 5d),
                                                    new Product("jogurt", 0.2d, 3d),
                                                    new Product("kefir", 0.2d, 5d),};

            Assert.IsTrue(productExpectedTable.SequenceEqual(productTable));
        }

        [TestMethod]
        public void TestQuickSortDouble()
        {
            double[] tab = new double[] {2.1d, 3.1d, 1.0d, 4.7d, 0.5d };
            double[] resultTab = QuickSort<double>.Sort(tab);
            double[] expectedTab = new double[] { 0.5d, 1.0d, 2.1d, 3.1d, 4.7d };
            Assert.IsTrue(expectedTab.SequenceEqual(resultTab));
        }
    }
}
