using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Algoritmen_Lesson_8
{
    /// <summary>
    /// Сортировка слиянием
    /// </summary>
    static class MergeSort_
    {
        public static List<int> Sort_MergeSort(this List<int> list)
        {
            var stack = new Stack<MinMaxPosition>();
            stack.Push(new MinMaxPosition(0, list.Count));
            var pos = new MinMaxPosition(0,0);
            while (stack.Count != 0)
            {
                pos = stack.Pop();

                if (pos.Min < pos.Max)
                {
                    if (pos.Max - pos.Min == 1)
                    {
                        if (list[pos.Max] < list[pos.Min]) TwoValuesExchange(list, pos.Min, pos.Max);
                    }
                    else
                    {
                        stack.Push(new MinMaxPosition(pos.Min, pos.Min + (pos.Min - pos.Max) / 2 ));
                        stack.Push(new MinMaxPosition(pos.Min + 1, pos.Max + (pos.Max - 1) / 2 + 1));
                    }
                }
            }

            return list;
        }

        static void TwoValuesExchange<T>(List<T> x, int i1, int i2) => (x[i1], x[i2]) = (x[i2], x[i1]);

    }
}
