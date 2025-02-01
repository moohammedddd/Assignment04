using Assignment04.Inheritance;

namespace Assignment04
{
    internal class Program
    {
        //static int SumTwoNUm(int x , int y)
        //{
        //    return x + y;   
        //}
        //static int SumThreNUm(int x, int y, int z)
        //{
        //    return x + y + z;
        //}
         
        static void Main(string[] args)
        {
            #region Inhertance 
           // Parent Class
            Parent Parent = new Parent(1, 2);
            Parent.x = 10;
            Parent.y = 20;
            Console.WriteLine(Parent);
           

            // Use Function Inside Class
            Console.WriteLine(Parent.Product());

            // Child Class 
            Child Child = new Child(1, 8, 3);
            Console.WriteLine(Child);
            Console.WriteLine(Child.Product());

            /// Type of Inheritance
            ///Single Inheritance : Class can inherit from only one base class
            ///Multilevel inheritance : Class can inherit from another class and class can inherit from yet another class
            /// example A => B => C 
            /// Herachaical Inheritance : Multiple classes can inherit from a single base class
            /// Why cant class inherit from more than class?
            /// because my be two class have the same name of methods and members or more ...
            /// 
            #endregion
        }
    }
}
