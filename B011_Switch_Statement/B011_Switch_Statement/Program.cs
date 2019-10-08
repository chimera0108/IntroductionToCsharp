using System;

namespace B011_Switch_Statement
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number ");
            int UserNumber = int.Parse(Console.ReadLine());

            #region If Statement
            /**
            if (UserNumber == 10)
            {
                Console.WriteLine("Your number is 10");
            }
            else if (UserNumber == 20)
            {
                Console.WriteLine("Your number is 20");
            }
            else if (UserNumber == 30)
            {
                Console.WriteLine("Your number is 30");
            }
            else
            {
                Console.WriteLine("Your number is NOT 10, 20, or 30!");
            }
            **/
            #endregion

            #region Switch Statement 1
            /**
            switch (UserNumber)
            {
                case 10:
                    Console.WriteLine("Your number is 10");
                    break;
                case 20:
                    Console.WriteLine("Your number is 20");
                    break;
                case 30:
                    Console.WriteLine("Your number is 30");
                    break;
                default:
                    Console.WriteLine("Your number is NOT 10, 20, or 30!");
                    break;
            }
            **/
            #endregion

            #region Switch Statement 2
            switch (UserNumber)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("Your number is {0}", UserNumber);
                    break;
                default:
                    Console.WriteLine("Your number is NOT 10, 20, or 30!");
                    break;
            }
            #endregion

            #region Keep Window Open
            Console.ReadLine();
            #endregion

        }
    }
}
