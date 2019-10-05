using System;

namespace Built_In_Types
{
    class Program
    {
        static void Main()
        {
            bool b = true;
            //has an error because the wrong value is assigned
            //b = 123;
            Console.WriteLine("b value is {0}", b);

            int i = 0;
            Console.WriteLine("Min = {0}", int.MinValue);
            Console.WriteLine("Max = {0}", int.MaxValue);
            Console.WriteLine("i value is {0}", i);

            double d = 123.22242433;
            Console.WriteLine("d value is {0}", d);
            //has an error because the wrong value is assigned
            //int dd = 123.22242433;

            decimal k = 123.22242433m;
            Console.WriteLine("k value is {0}", k);



            //To keep the window open
            Console.ReadLine();
        }
    }
}
