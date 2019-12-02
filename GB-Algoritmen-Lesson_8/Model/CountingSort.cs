using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Algoritmen_Lesson_8
{
    /// <summary>
    /// Сортировка подсчётом
    /// </summary>
    static class CountingSort_
    {
        public static List<int> Sort_CountingSort(this List<int> list)
        {
            var operations = 0;
            var mass = new int[list.Max()+1];
            for (int i = 0; i < list.Count; i++)
            {
                operations++;
                mass[list[i]]++;
            }

            var b = 0;

            for (int j = 0; j < mass.Length; j++)
                for (int i = 0; i < mass[j]; i++)
                {
                    operations++;
                    list[b++] = j;
                }

            return list;
        }
    }
}
