using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Practical_task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Complex a = new Complex(2, 3, "a", false);
                Complex b = new Complex(1, -1, "b", false);

                WriteLine($"a = {a},\t b = {b}");

                Complex sum = a.Add(b);
                Complex difference = a.Subtract(b);
                Complex product = a.Multiply(b);
                Complex quotient = a.Divide(b);

                WriteLine($"\nSum: {sum}");
                WriteLine($"Difference: {difference}");
                WriteLine($"Product: {product}");
                WriteLine($"Quotient: {quotient}");

                WriteLine($"\nMagnitude of a: {a.Magnitude:f2}");
                WriteLine($"Magnitude of b: {b.Magnitude:f2}");
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
