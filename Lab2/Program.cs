using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //10 variables with different data types
            int first = 25;
            float second = 6.4f;
            double third =  -5.62;
            bool fourth = true;
            char fifth  = 'O';
            short sixth = 31767;
            long seventh = 2343560;
            byte eighth = 254;
            decimal ninth = 7.95m;
            string tenth = "WellaHealth";
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
            Console.WriteLine(fourth);
            Console.WriteLine(fifth);
            Console.WriteLine(sixth);
            Console.WriteLine(seventh);
            Console.WriteLine(eighth);
            Console.WriteLine(ninth);
            Console.WriteLine(tenth);


            //Implicit type conversion
            long eleventh = first;
            Console.WriteLine(eleventh);

            //Explicit type conversion
            int twelfth = (int) third;
             Console.WriteLine(twelfth);


        }
    }
}