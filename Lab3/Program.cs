using System;

namespace Lab3
{
    class program
    {
        static void Main(string[] args)
        {
            int number;
            bool isPrime = true;
            Console.WriteLine("Enter the Number");
            number = Convert.ToInt32(Console.ReadLine());

            if(number < 1) 
            Console.WriteLine("Number needs to be greater than 1");
            else if (number == 1)
            Console.WriteLine("1 is neither Prime nor Composite");
            else{
                for( int divisor =2; divisor <= (number / 2); divisor++) {
                    if ( number % divisor == 0) {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    Console.WriteLine("{0} is a prime number", number);
                else
                    Console.WriteLine("{0} is a Composite number", number);
            }
        }
    }
}