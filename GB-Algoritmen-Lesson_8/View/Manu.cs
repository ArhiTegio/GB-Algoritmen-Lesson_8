﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GB_Algoritmen_Lesson_8
{
    class ViewCountingSort : Act
    {
        public override void Work()
        {
            WriteLine($"Сортировка подсчётом.");

            var list = new List<int>() { 4, 4, 1, 6, 3, 6, 1, 3, 0, 6, 4, 4, 1, 6 };
            list = new List<int>();
            var r = new Random();
            for (int i = 0; i < 100000; ++i)
                list.Add(r.Next(1,20));

            list = new List<int>();
            for (int i = 0; i < 100000; ++i)
                list.Add(i);
            list.Add(0);

            WriteLine($"Ответ стандартной реализации: {list.Sort_CountingSort().Select(x => x.ToString()).Aggregate((x, y) => $"{x} {y}")}");
        }
    }

    class ViewQuickSort : Act
    {
        public override void Work()
        {
            WriteLine($"Быстрая сортировка (Сортировка Хоара).");
            var list = new List<int>() { 4, 4, 1, 6, 3, 6, 1, 3, 0, 6, 4, 4, 1, 6 };

            list = new List<int>();
            var r = new Random();
            for (int i = 0; i < 100000; ++i)
                list.Add(r.Next(1, 100));

            list = new List<int>();
            for (int i = 0; i < 100000; ++i)
                list.Add(i);
            list.Add(0);

            WriteLine($"Ответ стандартной реализации: {list.Sort_QuickSort().Select(x => x.ToString()).Aggregate((x, y) => $"{x} {y}")}");
        }
    }

    class ViewMergeSort : Act
    {
        public override void Work()
        {
            WriteLine($"Сортировка слиянием.");
            var list = new List<int>() { 4, 4, 1, 6, 3, 6, 1, 3, 0, 6, 4, 4, 1, 6 };

            list = new List<int>();
            var r = new Random();
            for (int i = 0; i < 100000; ++i)
                list.Add(r.Next(1, 100));

            list = new List<int>();
            for (int i = 0; i < 100000; ++i)
                list.Add(i);
            list.Add(0);

            WriteLine($"Ответ стандартной реализации: {list.Sort_MergeSort().Select(x => x.ToString()).Aggregate((x, y) => $"{x} {y}")}");
        }
    }

    class ViewSortWithList : Act
    {
        public override void Work()
        {
            WriteLine($"Сортировка со списком (Голубиная сортировка, сортировка Дирихле).");
            var list = new List<int>() { 4, 4, 1, 6, 3, 6, 1, 3, 0, 6, 4, 4, 1, 6 };

            list = new List<int>();
            var r = new Random();
            for (int i = 0; i < 100000; ++i)
                list.Add(i);
            list.Add(0);

            WriteLine($"Ответ стандартной реализации: {list.Sort_PigeonholeSorting().Select(x => x.ToString()).Aggregate((x, y) => $"{x} {y}")}");
            var list2 = new List<int>() { 4, 4, 1, 6, 3, 6, 1, 3, 0, 6, 4, 4, 1, 6 };


            list2 = new List<int>();
            for (int i = 1; i < 100000; ++i)
                list2.Add(i);
            list2.Add(0);

            WriteLine($"Ответ с SortedDictionary реализации: {list2.Sort_PigeonholeSorting2().Select(x => x.ToString()).Aggregate((x, y) => $"{x} {y}")}");
        }
    }
}
