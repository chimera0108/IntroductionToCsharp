using System;

namespace B012_Loop_Version
{
    class Program
    {
        static void Main()
        {
            #region Initialize for If and Switch One and Two
            /**
            Console.WriteLine("Please enter a number ");
            int UserNumber = int.Parse(Console.ReadLine());
            **/
            #endregion

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
            /**
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
            **/
            #endregion

            #region 
            int TotalCoffeeCost = 0;
            string UserDecision = string.Empty;
            int UserChoice = 0;
            do
            {
                do
                {
                    Console.WriteLine("1 - Small, 2 - Medium, 3 - Large");
                    UserChoice = int.Parse(Console.ReadLine());
                    switch (UserChoice)
                    {
                        case 1:
                            TotalCoffeeCost += 1;
                            break;
                        case 2:
                            TotalCoffeeCost += 2;
                            break;
                        case 3:
                            TotalCoffeeCost += 3;
                            break;
                        default:
                            Console.WriteLine("Your choice {0} is invalid", UserChoice);
                            break;
                    }
                } while (UserChoice > 3 | UserChoice < 1);

                Console.WriteLine("Do you want to buy another coffee - Yes or No?");
                UserDecision = Console.ReadLine().ToUpper();

                do
                {
                    switch (UserDecision)
                    {
                        case "YES":
                        case "Y":
                            UserDecision = "Y";
                            break;
                        case "NO":
                        case "N":
                            UserDecision = "N";
                            break;
                        default:
                            Console.WriteLine("Your choice {0} is invalid. Please try again...", UserDecision);
                            UserDecision = Console.ReadLine().ToUpper();
                            break;
                    }
                } while (UserDecision != "Y" && UserDecision != "N");
            } while (UserDecision == "Y");

            Console.WriteLine("Thank you for shopping with us");
            Console.WriteLine("Bill Amount = ${0}.00", TotalCoffeeCost);
            #endregion


            #region Keep Window Open
            Console.ReadLine();
            #endregion            
        }
    }
}
