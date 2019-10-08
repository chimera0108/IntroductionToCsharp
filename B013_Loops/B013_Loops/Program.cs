using System;

namespace B013_Loops
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter your target number ");
            int UserTarget = int.Parse(Console.ReadLine());

            int Start = 0;
            while(Start <= UserTarget)
            {
                Console.Write(Start + " ");
                Start = Start + 2;
            }
            Console.WriteLine();

            #region Keep Window Open
            Console.ReadLine();
            #endregion

        }
    }
}
