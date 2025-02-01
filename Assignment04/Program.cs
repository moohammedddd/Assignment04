using Assignment04.Association.Composition;
using Assignment04.Inheritance;
using System.Numerics;

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


            #region Class
            ///Relationship between classes
            /// Type of Relationship 
            ///Inheritance is a relationship
            ///Association " use a " That class is use another class
            ///Composition " has a " 
            ///Association 
            /// one to one 
            /// one to many 
            /// many to many
            ///Association contain (Aggreation , composition)
            ///composition (Room amd Apartment) Apartment has a Room, Room is part of Apartment


            #endregion

            #region Association
            #region compostion
            

            Product p = new Product() { Name = "mohamed" };
            p.Id = 10;
            p.Name = "Ahmed";
            p.UnitPrice = 10;
            p.UnitOfSet = 20;
            Console.WriteLine(p.Name);
            OrderItem orderItem = new OrderItem() { Product = p };
            orderItem.Id = 10;
            Console.WriteLine(orderItem.Product.Name);

            #endregion

            #region Aggeration
            // It is Optional Association 

            #endregion

            #endregion

            #region Polymerphism-Function OverLoading
            // The word Polymorphism comes from Geek meaning many forms
            #region overloading
            //int result = SumTwoNUm(10, 20);
            //Console.WriteLine(result);
            //int result02 = SumThreNUm(10, 20, 30);
            //Console.WriteLine(result02);
            int result = Sum(1, 2);
            result = Sum(1, 2, 3);
            Sum(2.5, 3.6);
            Console.WriteLine(result);
            // it is more readable 
            // function not affect on performance 

            #endregion

            #region Operator Overloading Binary
            // this example is very important 
            Complex complex01 = new Complex();
            complex01.Real = 5;
            complex01.Imaginary = 2;
            Console.WriteLine(complex01);
            Complex complex02 = new Complex();
            complex02.Real = 5;
            complex02.Imaginary = 2;
            Console.WriteLine(complex02);
            Complex complex03 = complex01 + complex02;
            Console.WriteLine(complex03);

            Complex complex04 = complex01 + complex02 + complex03; // will sum 1 ,2 in one complex then sum it on 3

            //  Complex complex = complex04 + 5; cant make it 
            Complex complex05 = complex04 + 5;
            Console.WriteLine("after operator num on the equateion of complex");
            Console.WriteLine(complex05);

            // Complex complex05 =  5 + complex04;// it is not valied 
            // if i want to do it reflect the function
            #endregion

            #region Unary Operator
            Complex complex7 = complex05++;
            Console.WriteLine("-------------------------------");
            Console.WriteLine(complex05);
            Complex complex07 = ++complex05;
            #endregion

            #region Comparision
            if (complex01 > complex02)
            {
                Console.WriteLine("C1 is Greater than C2");
            }
            else Console.WriteLine("C1 less than  is C2 ");
            #endregion
            #endregion


        }
    }
}
