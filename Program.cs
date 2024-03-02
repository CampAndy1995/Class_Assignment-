using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Messages.Hello();

            Console.ReadKey();
        }
    }
    class Messages
    {
      public static void Hello()
        {
            Console.WriteLine("Hello! Welcome to the program!");
        }
       public static void Waiting()
        {
            Console.WriteLine("Is this the waiting line for the concert?");
        }
       public static void Bye()
        {
            Console.WriteLine("Bye! Come again!!");
        }
    }
}
