using System;

namespace _005_Common_Operators
{
    class Program
    {
        static void Main()
        {
            //Assignment Operator "="
            int i = 10;
            Console.WriteLine("i is {0}", i);
            bool b = true;
            Console.WriteLine("b is {0}", b);

            //Arithmetic Operators "+ - / %"
            int Numerator = 10;
            int Denominator = 2;
            int Result = Numerator / Denominator;
            int Remainder = Numerator % Denominator;
            Console.WriteLine("Numerator is {0}", Numerator);
            Console.WriteLine("Denominator is {0}", Denominator);
            Console.WriteLine("Result is {0}", Result);
            Console.WriteLine("Remainder is {0}", Remainder);

            //Comparison Operators
            int Number = 10;
            if (Number == 10)
            {
                Console.WriteLine("Number is equal to ten!");
            }
            if (Number != 10)
            {
                Console.WriteLine("Number is NOT equal to ten!");
            }
            if (Number <= 10)
            {
                Console.WriteLine("Number is less than or equal to 10");
            }
            if (Number >= 10)
            {
                Console.WriteLine("Number is greater than or equal to 10");
            }
            //Conditional Operators
            int AnotherNumber = 21;
            if (Number == 10 && AnotherNumber == 20)
            {
                Console.WriteLine("Number is equal to ten and AnotherNumber is equal to twenty.");
            }
            else
            {
                Console.WriteLine("Number is NOT equal to ten or AnotherNumber is NOT equal to twenty or both.");
            }
            if (Number == 10 || AnotherNumber == 20)
            {
                Console.WriteLine("Number is equal to ten or AnotherNumber is equal to twenty.");
            }
            else
            {
                Console.WriteLine("Number is NOT equal to ten AND AnotherNumber is NOT equal to twenty.");
            }
            //Ternary Operator
            bool IsNumber10;
            if(Number == 10)
            {
                IsNumber10 = true;
            }
            else
            {
                IsNumber10 = false;
            }
            Console.WriteLine("Number == 10 is {0}", IsNumber10);

            Number = 15;
            bool IsNumbers10 = Number == 10 ? true : false;
            Console.WriteLine("Number == 10 is {0}", IsNumbers10);

            //Null Coalescing Operator

            #region Keep Window Open
            Console.ReadLine();
            #endregion
        }
    }
}
