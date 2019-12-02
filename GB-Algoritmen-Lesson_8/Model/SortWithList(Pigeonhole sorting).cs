using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Algoritmen_Lesson_8
{
    /// <summary>
    /// Сортировка со списком (Голубиная сортировка, сортировка Дирихле)
    /// </summary>
    static class SortWithList_Pigeonhole_sorting_
    {
        static int operations = 0;
        /// <summary>
        /// Сортировка со списками 
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        static public List<int> Sort_PigeonholeSorting2(this List<int> list)
        {
            operations = 0;
            var dict = new SortedDictionary<int, int>();
            var hash = new HashSet<int>();
            foreach (var e in list)
                if (!hash.Contains(e))
                {
                    operations++;
                    hash.Add(e);
                    dict.Add(e, 1);
                }
                else
                {
                    dict[e]++;
                    operations++;
                }

            list.Clear();
            foreach (var e in dict)
                for (int i = 0; i < e.Value; ++i)
                {
                    list.Add(e.Key);
                    operations++;
                }
            return list;
        }


        public static List<int> Sort_PigeonholeSorting(this List<int> list)
        {
            operations = 0;

            int min = list[0];
            int max = list[0];
            int range, i, j, index;

            for (int a = 0; a < list.Count; a++)
            {
                if (list[a] > max)
                {
                    max = list[a];
                    operations++;
                }
                if (list[a] < min)
                {
                    min = list[a];
                    operations++;
                }
            }

            range = max - min + 1;
            int[] phole = new int[range];

            for (i = 0; i < list.Count; i++)
            {
                phole[list[i] - min]++;
                operations++;
            }
            
            index = 0;

            for (j = 0; j < range; j++)
                while (phole[j]-- > 0)
                {
                    list[index++] = j + min;
                    operations++;
                }

            return list;
        }

    }
}
