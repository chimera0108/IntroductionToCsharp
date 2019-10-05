using System;

namespace B009_Comments
{
    class Program
    {
        static void Main()
        {
            //Single Line Comment
            //Console.WriteLine("Hello");

            //Multiple Line Comments
            /*
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
            */

            /*
             *use the "Designer" buttons to comment/uncomment lines that are highlighted
             * Good when doing multiple lines
             * 
             * ctrl K, ctrl C to comment the highlighted lines
             * ctrl K, ctrl U to uncomment the highlighted lines
             */
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");

            //Uncomment and hover over it to see the comment that was added to that class
            //SampleClass
            #region Keep Window Open
            Console.ReadLine();
            #endregion

        }
    }

    /// <summary>
    /// This is a sample class and a sample documentation
    /// </summary>
    public class SampleClass
    {

    }
}
