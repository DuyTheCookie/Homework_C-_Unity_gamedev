using System;

namespace ConsoleApp3
{
    internal class program
    {
        static void Main(string[] args)
        {


            /*
            Console.Write("ban ten gi:");
            string name = Console.ReadLine();
            Console.WriteLine("ban ten la " + name);


            Console.Write("nam sinh cua ban la:");
            string year = Console.ReadLine();
            Console.WriteLine("nam sinh cua ban la " + year);

        


            string hi = "hello";
            hi = "Xin chao";
            Console.WriteLine(hi);
            */


            int min;
            int max;
            int a;
            int b;
            string userInput;

            Console.Write("Enter integer value: ");
            userInput = Console.ReadLine();
            /* Converts to integer type */
            a = Convert.ToInt32(userInput);
            Console.WriteLine("You entered " + a);

            Console.Write("Enter integer value: ");
            userInput = Console.ReadLine();
            /* Converts to integer type */
            b = Convert.ToInt32(userInput);
            Console.WriteLine("You entered: " + b);


            min = (a < b) ? a : b;
            max = (a > b) ? a : b;
            Console.WriteLine(min);
            Console.WriteLine(max);


            // basic if else 
            if(min % 2 == 0)
            {
                Console.Write("so" + min + " la so chan");
                
            }
            else 
            {
                Console.Write("so" + min + " khong phai so chan");
                
            }
        }
    }
}