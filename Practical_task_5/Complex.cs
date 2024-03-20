using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_task_5
{
    class Complex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }
        public string Name { get; set; } // Дополнительное поле для имени комплексного числа
        public bool IsReal { get; set; } // Дополнительное поле для определения, является ли число действительным
        public double Magnitude { get { return Math.Sqrt(Real * Real + Imaginary * Imaginary); } } // Дополнительное поле для определения модуля комплексного числа

        public Complex(double real, double imaginary, string name, bool isReal = false)
        {
            Real = real;
            Imaginary = imaginary;
            Name = name;
            IsReal = isReal;
        }

        public Complex Add(Complex other)
        {
            return new Complex(Real + other.Real, Imaginary + other.Imaginary, "");
        }

        public Complex Subtract(Complex other)
        {
            return new Complex(Real - other.Real, Imaginary - other.Imaginary, "");
        }

        public Complex Multiply(Complex other)
        {
            return new Complex(Real * other.Real - Imaginary * other.Imaginary,
                               Real * other.Imaginary + Imaginary * other.Real, "");
        }

        public Complex Divide(Complex other)
        {
            double denominator = other.Real * other.Real + other.Imaginary * other.Imaginary;
            return new Complex((Real * other.Real + Imaginary * other.Imaginary) / denominator,
                               (Imaginary * other.Real - Real * other.Imaginary) / denominator, "");
        }

        public override string ToString()
        {
            if (Imaginary < 0)
                return $"{Real} - {-Imaginary}i";
            else
                return $"{Real} + {Imaginary}i";
        }
    }
}
