using System;

namespace Lab4
{
    class program 
    {
        static void Main(String []args)
        {
            Console.WriteLine("Is sum of two numbers less the 100");
            Console.WriteLine("Input Numer one: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input Numer two: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double sum = num1 + num2;

            if(sum < 100){
               Console.WriteLine("True");
               
            } else {
               Console.WriteLine("False");
            }
        }

    }
}