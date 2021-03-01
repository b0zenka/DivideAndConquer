using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConquer
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] listOfProducts = new Product[] {    new Product("Masło", 1, 1.5),
                                                            new Product("Chleb", 1.5, 3),
                                                            new Product("Cebulka", 2, 4),
                                                            new Product("Dżem", 3, 3)};

            Product.DisplayProducts(MergeSorting<Product>.Sort(listOfProducts));

            Product[] listOfProducts2 = new Product[] {    new Product("Masło", 1, 1.5),
                                                            new Product("Chleb", 1.5, 3),
                                                            new Product("Cebulka", 2, 4),
                                                            new Product("Dżem", 3, 3)};
            Product.DisplayProducts(QuickSort<Product>.Sort(listOfProducts2));

            Console.WriteLine("\nPodaj 10 losowych liczb od 0 do 1000");
            double[] table = new double[10];
            double[] table2 = new double[10];
            double temp;
            try
            {
                for (int i = 0; i < table.Length; i++)
                {
                    Console.Write($"{i}: ");
                    if (double.TryParse(Console.ReadLine(), out temp))
                        table[i] = temp;
                    else
                        throw new Exception("Nie podano liczby");
                }

                table.CopyTo(table2, 0);

                QuickSort<double>.Sort(table);
                Console.WriteLine("\n Wynik Quick sort:");
                DisplayArray(table);

                MergeSorting<double>.Sort(table2);
                Console.WriteLine("\n Wynik MergeSort sort:");
                DisplayArray(table2);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Błąd: {e}");
            }
           
            Console.ReadKey();
        }

        private static void DisplayArray(double [] table)
        {
            foreach (var item in table)
            {
                Console.WriteLine(item);
            }
        }
    }
}
