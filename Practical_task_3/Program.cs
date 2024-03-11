using System;

namespace Number_of_Fibonachi
{
    internal class Program
    {
        private enum Choice
        {
            Рекурсия = 1,
            Итерация,
            Выход
        }

        private static int FRecursive(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return FRecursive(n - 1) + FRecursive(n - 2);
            }
        }

        private static double FIterative(int n)
        {
            const double fi = 1.618103;

            return (Math.Pow(fi, n) - Math.Pow((1 - fi), n) / Math.Sqrt(5));
        }

        private static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.Write("Выберите метод:\n1 - Рекурсия\n2 - Итерация:\n");
                    Console.Write("Ваш выбор: ");
                    int n;

                    if (Enum.TryParse(Console.ReadLine(), out Choice choice))
                    {
                        Console.Clear();
                        switch (choice)
                        {
                            case Choice.Рекурсия:

                                int startTicksRecursive = Environment.TickCount;
                                Console.Write("Введите количество иттераций: ");
                                n = int.Parse(Console.ReadLine());

                                Console.WriteLine("Ход выполнения:");

                                for (int i = 0; i < n; i++)
                                {
                                    Console.Write($"{FRecursive(i)}  ");
                                }
                                int endTicksRecursive = Environment.TickCount;
                                double elapsedTimeInSeconds = (endTicksRecursive - startTicksRecursive) / 1000.0;

                                Console.WriteLine($"\nВремя выполнения: {elapsedTimeInSeconds:F2} сек");
                                break;

                            case Choice.Итерация:

                                int startTicksIteration = Environment.TickCount;
                                Console.Write("Введите количество иттерациий");
                                n = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ход выполнения:");
                                for (int i = 0; i < n; i++)
                                {
                                    Console.Write($"{FIterative(i):F0}  ");
                                }

                                int endTicksItteration = Environment.TickCount;
                                double TimeInSecondsItteration = (endTicksItteration - startTicksIteration) / 1000.0;

                                Console.WriteLine($"\nВремя выполнения: {TimeInSecondsItteration:F2} сек");
                                break;

                            case Choice.Выход:

                                Environment.Exit(0);

                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Неправльный выбор");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
                Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
        }
    }
}