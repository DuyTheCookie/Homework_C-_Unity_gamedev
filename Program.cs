using System;

namespace ConsoleApp3
{
    internal class program
    {
        static void Main(string[] args)
         {


            string year;
            Console.Write("ban ten gi:");
            string name = Console.ReadLine();
            Console.WriteLine("ban ten la " + name);


            Console.Write("nam sinh cua ban la:");
            string year = Console.ReadLine();
            Console.WriteLine("nam sinh cua ban la " + year);

            Console.Write("tuoi cua ban la:");
            year = Convert.ToInt32(year);
            int age = 2022 - year;
            Console.WriteLine("tuoi cua ban la " + age);


            string hi = "hello";
            hi = "Xin chao";
            Console.WriteLine(hi);



            int min;
            int max;
            int a ;
            int b ;
            string userInput;

            Console.Write("Enter integer value: ");
            userInput = Console.ReadLine();
            /* Converts to integer type */
            a = Convert.ToInt32(userInput);
            Console.WriteLine("You entered {0}" + a);

            Console.Write("Enter integer value: ");
            userInput = Console.ReadLine();
            /* Converts to integer type */
            b = Convert.ToInt32(userInput);
            Console.WriteLine("You entered: " + b);


            min = (a < b) ? a : b;
            max = (a > b) ? a : b;
            Console.WriteLine(min);
            Console.WriteLine(max);

        }
    }
}