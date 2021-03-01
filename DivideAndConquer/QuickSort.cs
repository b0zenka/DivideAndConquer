using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConquer
{
    public static class QuickSort<T>
    {
        public static T[] Sort(T [] array)
        {
            QuickSorting(array, 0, array.Length - 1);
           
            return array;
        }

        private static void QuickSorting(T[] array, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partion(array, left, right);
                if (pivot > 1)
                {
                    QuickSorting(array, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSorting(array, pivot + 1, right);
                }
            }
            else
                return;

        }

        private static int Partion(T[] array, int left, int right)
        {
            dynamic pivot = array[left];
            
            while (true)
            {
                while (array[left] < pivot)
                {
                    left++;
                }
                while (array[right] > pivot)
                {
                    right--;                    
                }

                if (left < right)
                {
                    dynamic temp = array[left];
                    if (array[right] == temp)
                        return right;
                    array[left] = array[right];
                    array[right] = temp;
                }
                else
                    return right;
            }
        }
    }
}
