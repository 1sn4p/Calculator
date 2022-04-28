using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Formula
    {
      
    }
    class Program
    {
        public static void Addition(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine(sum);

        }
        public static void Subtraction(int a, int b)
        {
            int difference = a - b;
            Console.WriteLine(difference);


        }
        public static void Division(int a, int b)
        {
            int quotient = a / b;
            Console.WriteLine(quotient);


        }
        public static void Multiplication(int a, int b)
        {
            int product = a * b;
            Console.WriteLine(product);


        }
        static void Main(string[] args)
        {
       
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Choose Operator");
            string operators = Convert.ToString(Console.ReadLine());
            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("*");
            Console.WriteLine("/");


            if (operators == "+")
            {
                Addition(x, y);
            }
            else if (operators == "-")
            {
                Subtraction(x, y);
            }
            else if (operators == "*")
            {
                Multiplication(x, y);
            }
            else if (operators == "/")
            {
                Division(x, y);
            }





        }

      
    }
}
