using System;

    class Program
    {
        static void Main()
        {
        Console.WriteLine("Please Enter Your Name ");
        //Below reading the answer from the command line.
        string UserName = Console.ReadLine();
        //Below is concatination example
        //Console.WriteLine("Hello " + UserName);
        Console.WriteLine("Hello {0}", UserName);
        Console.ReadLine();
        }
    }
