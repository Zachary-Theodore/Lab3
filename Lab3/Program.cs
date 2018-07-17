using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Restart2()
        {
            Console.WriteLine("Would you like to Re-Enter a number?(y/n)");
            string input2 = Console.ReadLine();
            if (input2 == "y" || input2 == "Y")
            {
                Main();
            }
            else
            {
                return;
            }
        }
        static void Restart()
        {
            Console.WriteLine("Sorry You Did not Input a Correct Number, Please Try Again.");
            Main();
        }
        static void Main()
        {

            //Input
            Console.WriteLine("Hello, Please Enter Your Name: ");
            string name1 = Console.ReadLine();
            Console.WriteLine($"Hello {name1},");
            Console.WriteLine("Please Input a Number Betqween 1 and 100: ");
            int input1 = int.Parse(Console.ReadLine());
            if (input1 > 100 || input1 < 1)
            {
                Restart();
            }

            else if (input1 % 2 != 0)
            {
                Console.WriteLine($"{name1}, Your Number {input1} is Odd.");
                Restart2();
                
            }
           else if (input1 >= 2 && input1 <= 24)
            {
                Console.WriteLine($"{name1}, Your Number {input1} is Even and Less Than 25.");
                Restart2();
            }
            else
            {
                Console.WriteLine($"{name1}, Your Number {input1} Is Even.");
                Restart2();
            }
        }
    }
}
