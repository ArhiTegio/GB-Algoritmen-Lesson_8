using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Algoritmen_Lesson_8
{
    /// <summary>
    /// Быстрая сортировка (Сортировка Хоара)
    /// </summary>
    static class QuickSort_HoareSorting_
    {

        static int operations = 0;
        public static List<int> Sort_QuickSort(this List<int> list)
        {
            operations = 0;
            if (list.Count <= 32) return list.Sort_InsertionSort();
            var stack = new Stack<MinMaxPosition>();
            stack.Push(new MinMaxPosition(0, list.Count-1));

            var pos = new MinMaxPosition(0, 0);
            var median = 0;
            while (stack.Count != 0)
            {
                pos = stack.Pop();
                if(pos.Min < pos.Max)
                {
                    operations++;
                    median = Check(list, pos.Min, pos.Max);
                    stack.Push(new MinMaxPosition(pos.Min, median - 1));
                    stack.Push(new MinMaxPosition(median + 1, pos.Max));
                }
            }
            return list;
        }

        private static int Check(List<int> list, int a, int b)
        {
            int i = a;
            for (int j = a; j <= b; j++)           
                if (list[j].CompareTo(list[b]) <= 0)
                {
                    operations++;
                    TwoValuesExchange<int>(list, i, j);
                    i++;
                }
            return i - 1;
        }

        static void TwoValuesExchange<T>(List<T> x, int i1, int i2) => (x[i1], x[i2]) = (x[i2], x[i1]);
    }

    class MinMaxPosition
    {
        public MinMaxPosition(int min, int max)
        {
            Min = min;
            Max = max;
        }

        public int Min { get; set; }
        public int Max { get; set; }
    }
}
