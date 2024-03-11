using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Practrical_task_2
{
    internal class Program
    {
        /// <summary>
        /// Линейный поиск
        /// </summary>
        /// <param name="array">Массив целых значений</param>
        /// <param name="seeking_value">Искомое значение</param>
        /// <returns>Индекс искомого значения</returns>
        static int LinearSearch(int[] array, int seeking_value)
        {
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] == seeking_value) { return i; }
            }
            return -1;
        }
        /// <summary>
        /// Поиск в хэш-таблице
        /// </summary>
        /// <param name="hashtable">Хэш-таблица</param>
        /// <param name="seeking_value">Искомое значение</param>
        /// <returns>Значение</returns>
        static int HashtableSearch(Dictionary<int, int> hashtable, int key)
        {
            if (hashtable.ContainsKey(key)) { return hashtable[key]; }
            else { return -1; }
        }
        static void Main(string[] args)
        {
            try
            {
                //Временная сложность алгоритма поиска О(n) (n - кол-во элементов)
                //зависит от размера объема данных, что может привести к задержкам, если объем большой
                int[] array = { 1, 6, 3, 0, 8, 2, 7, 4, 5, 9 };
                int seeking_value = 7;
                int search_1 = LinearSearch(array, seeking_value);
                if (search_1 != -1) { WriteLine($"Linear search: Element {seeking_value} fount at index {search_1}"); }
                else { WriteLine($"Element {seeking_value} not found"); }

                WriteLine("\n");

                //Временная сложность алгоритма поиска в среднем О(1), является более эффективным,
                //т.к. имеет постоянное время выполнения
                Dictionary<int, int> hashtable = new Dictionary<int, int>()
                {
                    {1, 3}, {2, 1}, {5, 6}, {8, 4}, {3, 5}, {4, 2}
                };
                int key = 8;
                int search_2 = HashtableSearch(hashtable, key);
                if (search_2 != -1) { WriteLine($"Hashtable search: Element for key {key}: {search_2}"); }
                else { WriteLine($"Element for key {key} not found"); }
            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
