using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConquer
{
    public class Product
    {
        private readonly string NAME;
        private readonly double VALUE;
        private readonly double WEIGHT;
        public double Profitability
        {
            get;
            private set;
        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="name">nazwa produktu</param>
        /// <param name="weight">waga</param>
        /// <param name="value">wartoś</param>
        public Product(string name, double weight, double value)
        {
            this.NAME = name;
            this.WEIGHT = weight;
            this.VALUE = value;
            this.Profitability = value / weight;
        }

        public override string ToString()
        {
            return string.Format("{0} kosztuje: {1:C2}, waży {2:N2}kg", NAME, VALUE, WEIGHT);
        }

        /// <summary>
        /// Wyświetla listę produktów
        /// </summary>
        /// <param name="listOfProducts">lista produktów</param>
        public static void DisplayProducts(List<Product> listOfProducts)
        {
            int i = 0;
            Console.WriteLine("Lista produktów: ");
            foreach (var product in listOfProducts)
            {
                Console.WriteLine(string.Format("{0}: {1}", ++i, product.ToString()));
            }
        }

        public static void DisplayProducts(Product [] tabProducts)
        {
            int i = 0;
            Console.WriteLine("Lista produktów: ");
            foreach (var product in tabProducts)
            {
                Console.WriteLine(string.Format("{0}: {1}", ++i, product.ToString()));
            }
        }

        public static bool operator < (Product product1, Product product2)
        {
            if (product1.Profitability == product2.Profitability)
            {
                return product1.WEIGHT > product2.WEIGHT;
            }
            return product1.Profitability < product2.Profitability;
        }

        public static bool operator <= (Product product1, Product product2)
        {
            return ((product1 < product2) || (product1 == product2));
        }

        public static bool operator > (Product product1, Product product2)
        {
            return product2 < product1;
        }

        public static bool operator >= (Product product1, Product product2)
        {
            return product2 <= product1;
        }

        public static bool operator == (Product product1, Product product2)
        {
            return (product1.Profitability == product2.Profitability && product1.WEIGHT == product2.WEIGHT);
        }

        public static bool operator != (Product product1, Product product2)
        {
            return !(product1 == product2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
         
            Product productObj = (Product) obj;
            return (NAME.Equals(productObj.NAME) 
                            && VALUE.Equals(productObj.VALUE) 
                            && WEIGHT.Equals(productObj.WEIGHT));
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
