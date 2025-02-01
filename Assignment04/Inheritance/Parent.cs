using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04.Inheritance
{
    internal class Parent
    {
        public int x { get; set; }
        public int y { get; set; }

        public Parent(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public override string ToString()
        {
            return $"x is {x} y is {y}";
        }

        public /*virtual*/ int Product() // virtual it make function flexable and can edit it in child
        {
            return x * y;
        }
    }
}
