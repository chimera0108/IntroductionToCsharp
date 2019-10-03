using System;

namespace B007_Datatype_Conversion
{
    class Program
    {
        static void Main()
        {
            #region Automatic Conversion implicitly
            //int i = 100;
            //float f = i;
            #endregion
            #region Explicit Conversions
            #region Type Caste Operator
            //float f = 123.45f;
            //float f = 1273733434333.45f;//Too Large but no exception thrown
            //int i = (int)f;
            #endregion
            #region Dot Net Convert Function
            //float f = 123.45f;
            //float f = 1273733434333.45f;//Too Large and an exception is thrown
            //int i = Convert.ToInt32(f);
            #endregion
            #region String to Number
            //string strNumber = "100";
            //string strNumber = "100TG";//Exception thrown because of Alpha Characters
            //int i = int.Parse(strNumber);
            #endregion

            //Console.WriteLine(i);

            #region String to Number TryParse
            string strNumber = "100";
            //string strNumber = "100TG";//Exception thrown because of Alpha Characters
            int i;
            bool IsConversionSuccessful = int.TryParse(strNumber, out i);
            if (IsConversionSuccessful)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
            #endregion
            #endregion



            #region Keep Window Open
            Console.ReadLine();
            #endregion
        }
    }
}
