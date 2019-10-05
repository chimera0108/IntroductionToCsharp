using System;

namespace _006_Nullable_Types
{
    class Program
    {
        static void Main()
        {
            string Name = null;
            if (Name == null)
            { }

            //i is a value type and cannot be null
            //int i = null;
            //Adding a question mark will make a value type nullable
            int? i = null;
            if (i == null)
            { }

            #region Making Value Type Nullable Example
            /*
            bool? AreYouAMajor = null;

            Console.WriteLine("First Name? ");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Last Name ? ");
            string LastName = Console.ReadLine();
            Console.WriteLine("Do you have the rank of Major? ");
            string AreYouAMajor2 = Console.ReadLine(); 
            switch (AreYouAMajor2)
            {
                case "Y":
                case "y":
                case "Yes":
                case "yes":
                    AreYouAMajor = true;
                    break;
                case "N":
                case "n":
                case "No":
                case "no":
                    AreYouAMajor = false;
                    break;
            }

            try
            {
                if (AreYouAMajor == true)
                {
                    Console.WriteLine("User is a Major");
                }
                else if (AreYouAMajor == false)
                {
                    Console.WriteLine("User is not the rank of Major");
                }
                else if (AreYouAMajor.Value)
                {
                    Console.WriteLine("Checking AreYouAMajor for a value");
                }
                else
                {
                    Console.WriteLine("AreYouAMajor is still null!");
                }
            }
            catch
            {
                Console.WriteLine("Oh Crap!");
            }
            */
            #endregion

            #region Null Coalescing Operator
            //int? TicketsOnSale = null;
            int? TicketsOnSale = 100;

            #region The 1st way
            /* 
            int AvailableTickets;

            if(TicketsOnSale == null)
            {
                AvailableTickets = 0;
            }
            else
            {
                AvailableTickets = TicketsOnSale.Value;
                //OR
                //AvailableTickets = (int)TicketsOnSale;
            }
            */
            #endregion
            
            #region The 2nd way
            int AvailableTickets = TicketsOnSale ?? 0;
            #endregion

            Console.WriteLine("Available Tickets = {0}", AvailableTickets);
            #endregion

#region Keep Window Open
Console.ReadLine();
#endregion

}
}
}
