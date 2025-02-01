using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }

        // to make overloading on operator should be : non private Class Member Function
        public static Complex operator +(Complex left, Complex right)
        {

            return new Complex()
            {
                Real = (left?.Real ?? 0) + (right?.Real ?? 0),
                Imaginary = (left?.Imaginary ?? 0) + (right?.Imaginary ?? 0),
            };
        }
        public static Complex operator +(Complex left, int right)
        {

            return new Complex()
            {
                Real = (left?.Real ?? 0) + (right),
                Imaginary = (left?.Imaginary ?? 0) + (right),
            };
        }

        public static Complex operator ++(Complex one)
        {
            return new Complex
            {
                Real = 1 + (one?.Real ?? 0),
                Imaginary = (one?.Imaginary ?? 0)
            };
        }

        public static bool operator >(Complex left, Complex right)
        {
            if (left.Real == right.Real)
            {
                return left?.Imaginary == right?.Imaginary;
            }
            else return left?.Real > right?.Real;
        }

        public static bool operator <(Complex left, Complex right)
        {
            if (left.Real == right.Real)
            {
                return left?.Imaginary == right?.Imaginary;
            }
            else return left?.Real > right?.Real;
        }
    }
}

