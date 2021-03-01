using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DivideAndConquer;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class DivideAndConqureTest
    {
        [TestMethod]
        public void TestSortTableInts()
        {
            int[] tab = new int[] { 10, 5, 6, 4, 3 };
            int[] resultTab = MergeSorting<int>.Sort(tab);
            int[] expectedTab = new[] { 3, 4, 5, 6, 10 };
 
            Assert.IsTrue(Enumerable.SequenceEqual(resultTab, expectedTab));
        }

        [TestMethod]
        public void TestSortTableProduct()
        {
            Product[] productTable = new Product[] { new Product("jogurt", 0.2d, 3d),
                                                    new Product("margaryna", 0.5d, 3d),
                                                    new Product("masło", 0.5d, 5d),
                                                    new Product("kefir", 0.2d, 5d)};
            MergeSorting<Product>.Sort(productTable);

            Product[] productExpectedTable = new Product[] { new Product("margaryna", 0.5d, 3d),
                                                    new Product("masło", 0.5d, 5d),
                                                    new Product("jogurt", 0.2d, 3d),
                                                    new Product("kefir", 0.2d, 5d),};

            Assert.IsTrue(productExpectedTable.SequenceEqual(productTable));
        }
    }
}
