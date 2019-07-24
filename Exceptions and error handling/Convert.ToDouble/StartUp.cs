namespace Convert.ToDouble
{
    using System;
    using System.Globalization;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            try
            {
                NumberFormatInfo provider = new NumberFormatInfo();
                provider.NumberDecimalSeparator = ",";
                provider.NumberGroupSeparator = ".";
                provider.NumberGroupSizes = new int[] { 3 };

                string[] values = {"12,3456789", "234,675",
                                      "12345,6789"};

                Console.Write("Converted double value "
                                 + "of specified strings: ");

                for (int j = 0; j < values.Length; j++)
                {
                    GetValue(values[j], provider);
                }
            }

            catch (FormatException fe)
            {

                Console.WriteLine("\n");
                Console.Write("Exception Thrown: ");
                Console.Write("{0}", fe.GetType(), fe.Message);
                Console.WriteLine("\n");
            }

            catch (OverflowException oe)
            {

                Console.WriteLine("\n");
                Console.Write("Exception Thrown: ");
                Console.Write("{0}", oe.GetType(), oe.Message);
                Console.WriteLine("\n");
            }
        }

        public static void GetValue(string str, NumberFormatInfo provider)
        {

            double value = Convert.ToDouble(str, provider);

            Console.Write($"{value}, ");
        }
    }
}

