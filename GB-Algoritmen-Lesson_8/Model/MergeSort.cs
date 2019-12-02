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
        static int[] temporaryArray;
        static int operations = 0;

        public static List<int> Sort_MergeSort(this List<int> list)
        {
            var stack = new Stack<MinMaxPosition>();
            operations = 0;
            temporaryArray = new int[list.Count];

            stack.Push(new MinMaxPosition(0, list.Count - 1));
            var pos = new MinMaxPosition(0, 0);
            while (stack.Count != 0)
            {
                pos = stack.Pop();

                if (pos.Min != pos.Max)
                {
                    var middle = (pos.Min + pos.Max) / 2;
                    stack.Push(new MinMaxPosition(pos.Min, middle));
                    stack.Push(new MinMaxPosition(middle + 1, pos.Max));
                    Merge(list, pos.Min, middle, pos.Max);
                }
            }

            return list;
        }

        static void Merge(List<int> list, int min, int middle, int max)
        {
            var leftPos = min;
            var rightPos = middle + 1;
            var length = max - min + 1;
            for (int i = 0; i < length; i++)
            {
                if (rightPos > max || (leftPos <= middle && list[leftPos] < list[rightPos]))
                {
                    operations++;
                    temporaryArray[i] = list[leftPos];
                    leftPos++;
                }
                else
                {
                    operations++;
                    temporaryArray[i] = list[rightPos];
                    rightPos++;
                }
            }
            for (int i = 0; i < length; i++)
            {
                operations++;
                list[i + min] = temporaryArray[i];
            }
        }
    }
}
