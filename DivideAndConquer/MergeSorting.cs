using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConquer
{
    public static class MergeSorting<T>
    {
        public static T[] Sort(T[] tab)
        {
            MergeSort(tab, 0, tab.Length - 1);
            return tab;
        }

        private static void MergeSort(T[] tab, int left, int right)
        {
            if (left >= right)
                return;
            else
            {
                int center = (left + right) / 2;
                MergeSort(tab, left, center);
                MergeSort(tab, center + 1, right);

                Scal(tab, left, center, right);
            }
        }

        private static void Scal(T[] tab, int left, int center, int right)
        {
            dynamic[] tempTab = new dynamic[right + 1];

            for (int i = left; i <= right; i++)
            {
                tempTab[i] = tab[i];
            }

            int lef = left;
            int cen = center + 1;
            for (int i = left; i <= right; i++)
            {
                if (lef <= center)
                {
                    if (cen <= right)
                    {
                        if (tempTab[lef] < tempTab[cen])
                            tab[i] = tempTab[lef++];
                        else
                            tab[i] = tempTab[cen++];
                    }
                    else
                    {
                        tab[i] = tempTab[lef++];
                    }
                }
                else
                {
                    tab[i] = tempTab[cen++];
                }    
            }
        }
    }

}
