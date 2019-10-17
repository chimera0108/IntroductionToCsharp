using System;

namespace B014_Do_While_Loop
{
    class Program
    {
        static void Main()
        {
            string UserChoice = "Y";

            while (UserChoice == "Y")
            {
                Console.WriteLine("Please enter your target? ");
                int UserTarget = int.Parse(Console.ReadLine());

                int Start = 0;
            
                while (Start <= UserTarget)
                {
                    Console.Write(Start + " ");
                    Start = Start + 2;
                }
                Console.WriteLine();

                do
                {
                    Console.WriteLine("Do you want to continue - Yes or No?");
                    UserChoice = Console.ReadLine().ToUpper();

                    switch (UserChoice)
                    {
                        case "YES":
                        case "Y":
                            UserChoice = "Y";
                            break;
                        case "NO":
                        case "N":
                            UserChoice = "N";
                            break;
                        default:
                            Console.WriteLine("Your choice {0} is invalid. Please try again...", UserChoice);
                            break;
                    }
                } while (UserChoice != "Y" && UserChoice != "N");
            }


            #region Keep Window Open
            Console.ReadLine();
            #endregion
        }
    }
}
