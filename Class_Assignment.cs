using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment 
{
    class Program
    {
        static void Main(string[] args)
        {

            double total;

            total = Multiply(2, 3);

            Console.WriteLine(total);
            Console.ReadKey();

            //Messages.Hello();
            //Messages.Waiting();
            //Messages.Bye();

            //Console.ReadKey();
        }
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }


    //class Messages
    //{
    //  public static void Hello()
    //    {
    //        Console.WriteLine("Hello! Welcome to the program!");
    //    }
    //   public static void Waiting()
    //    {
    //        Console.WriteLine("Is this the waiting line for the concert?");
    //    }
    //   public static void Bye()
    //    {
    //        Console.WriteLine("Bye! Come again!!");
    //    }
    //}
}
