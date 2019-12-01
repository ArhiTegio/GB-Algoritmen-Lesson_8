using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Algoritmen_Lesson_8
{
    static class InsertionSort_
    {
        public static List<int> Sort_InsertionSort(this List<int> list)
        {
            var operations = 0;
            for (int i = 0; i < list.Count; i++)
            {
                int temp = list[i];
                int j = i;
                while (j > 0 && list[j - 1] > temp)
                {
                    operations++;
                    TwoValuesExchange(list, j, j - 1);
                    j--;
                }
            }

            return list;
        }

        static void TwoValuesExchange<T>(List<T> x, int i1, int i2) => (x[i1], x[i2]) = (x[i2], x[i1]);
    }
}
