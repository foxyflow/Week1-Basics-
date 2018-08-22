using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //using variables
            int num = 10;
            string name = "Luke";
            
            //output
            Console.WriteLine(num);
            Console.WriteLine(name);

            //input
            Console.ReadLine();
            //Console reads 10 
            //Luke


            Console.WriteLine("this app displays your name age and address");
            Console.ReadLine();
            
            Console.WriteLine("what is your username?");
            string user = Console.ReadLine();

            Console.WriteLine($"Hello {user}");
            Console.WriteLine("what is your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your address?");
            string address = Console.ReadLine();
            Console.WriteLine("so you live at {0} and your age is {1}, I know everything I need to know {2}", address, age, user);
            Console.WriteLine("press enter to continue if nothing happens");

            Console.WriteLine("what's your lastname?");
            string lastname = Console.ReadLine();
            Console.WriteLine($"okay {user  + lastname} time to move on", user, lastname); 
            Console.Clear();

            ///math///

            Console.WriteLine("Math: enter a number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter another number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 + num2));
            Console.WriteLine("{0} / {1} = {2}", num1, num2, (num1 / num2));
            Console.WriteLine("{0} minus {1} equals {2}", num1, num2, (num1 - num2));
            String fullName = user +" " + lastname;
            Console.WriteLine("thank you {0} ", fullName);
            Console.WriteLine("thanks again " + fullName);
            Console.ReadLine();













            






        }
    }
}
