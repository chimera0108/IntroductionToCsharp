using System;

namespace B008_Arrays
{
    class Program
    {
        static void Main()
        {
            int[] EvenNumbers = new int[3];

            EvenNumbers[0] = 0;
            EvenNumbers[1] = 2;
            EvenNumbers[2] = 4;

            Console.WriteLine(EvenNumbers[1]);

            #region Keep Window Open
            Console.ReadLine();
            #endregion

        }
    }
}
