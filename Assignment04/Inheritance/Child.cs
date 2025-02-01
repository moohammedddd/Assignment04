using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04.Inheritance
{
    internal class Child : Parent
    {
        //public int x {  get; set; } // Duplicated it writen in Class Parent
        // public int y { get; set; } // Duplicated it writen in Class Parent
        // inhertance is allowd if i havent parmater constructor 
        public int z { get; set; }  // It is New

        public Child(int x, int y, int _z) : base(x, y) // i will make chain on base it inheart from Parent (x,y)
        {
            z = _z;
        }

        //public override string ToString()
        //{
        //    return $"x is {x} y is {y} z is {z}";
        //}

        public override string ToString()
        {
            return base.ToString() + $" z is {z}"; // 
        }

        //public override int Product()
        //{
        //    return base.Product()*z;
        //}
        // i can use function without virtual 
        // I have override and new
        public new int Product()
        {
            return base.Product() * z;
        }

    }
}
