using System;

namespace B010_If_Statements
{
    class Program
    {
        static void Main()
        {
            int Result = 0;
            Console.WriteLine("Please enter a number ");
            int UserNumber = int.Parse(Console.ReadLine());
            /*
            if (UserNumber == 1)
            {
                Console.WriteLine("Your number is one.");
            }
            if (UserNumber == 2)
            {
                Console.WriteLine("Your number is two.");
            }
            if (UserNumber == 3)
            {
                Console.WriteLine("Your number is three.");
            }
            if (UserNumber != 1 && UserNumber != 2 && UserNumber != 3)
            {
                Console.WriteLine("Your number is not between 1 and 3");
            }
            else
            {
                Console.WriteLine("Your number is not valid");
            }
            */

            //A bit more efficient since it stops evaluation once a condition is met
            if (UserNumber == 1)
            {
                Console.WriteLine("Your number is one.");
            }
            else if (UserNumber == 2)
            {
                Console.WriteLine("Your number is two.");
            }
            else if (UserNumber == 3)
            {
                Console.WriteLine("Your number is three.");
            }
            else if (UserNumber != 1 && UserNumber != 2 && UserNumber != 3)
            {
                Console.WriteLine("Your number is not between 1 and 3");
            }
            else
            {
                Console.WriteLine("Your number is not valid");
            }

            if (UserNumber == 10 || UserNumber == 20)
            {
                Console.WriteLine("Your number is 10 or 20");
            }
            else
            {
                Console.WriteLine("Your number is NOT 10 or 20");
            }
            // || the compiler will only check until one condition is true.
            // | the compiler will chedk all conditions to see if they are true.
            // && the compiler will stop checking conditions once a false is found
            // & the compiler will check all conditionals

            #region Keep Window Open
            Console.ReadLine();
            #endregion
        }
    }
}
