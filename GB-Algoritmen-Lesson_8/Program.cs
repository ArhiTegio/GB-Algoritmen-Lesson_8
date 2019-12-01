using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryFastDecisions;
using static System.Console;
using System.Reflection;

namespace GB_Algoritmen_Lesson_8
{
    class Program
    {
        static Dictionary<string, Act> dict = new Dictionary<string, Act>
        {
            { "1", new ViewCountingSort() },
            { "2", new ViewQuickSort() },
            { "3", new ViewMergeSort() },
            { "4", new ViewSortWithList() },
        };

        static void Main(string[] args)
        {
            var ex = new Extension();
            var q = new Questions();
            var n = "";
            WriteLine("С# - Алгоритмы и структуры данных. Задание 8.");
            WriteLine("Кузнецов");
            var list = new HashSet<char>(dict.Select(x => x.Key[0]));
            while (n != "0")
            {
                WriteLine("Введите номер интересующей вас задачи:" + Environment.NewLine +
                    "1. Реализовать сортировку подсчётом." + Environment.NewLine +
                    "2. Реализовать быструю сортировку." + Environment.NewLine +
                    "3. * Реализовать сортировку слиянием." + Environment.NewLine +
                    "4. **Реализовать алгоритм сортировки со списком." + Environment.NewLine +
                    " Проанализировать время работы каждого из вида сортировок для 100, 10000, 1000000 элементов.Заполнить таблицу." + Environment.NewLine +
                    "0. Нажмите для выхода из программы.");

                n = q.Question<int>("Введите ", new HashSet<char>() { '0', '1', '2', '3', '4' }, true);
                if (n == "0") break;
                dict[n].Work();
            }

            Console.ReadKey();
        }
    }

    abstract class Act
    {
        public abstract void Work();
    }
}
