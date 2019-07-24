namespace EnterNumbers
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int startNumber = 2;
            int endNumber = 15;

            ReadNumber(startNumber, endNumber);
        }

        public static void ReadNumber(int startNumber, int endNumber)
        {
            for (int i = 0; i < 10; i++)
            {
                var number = Console.ReadLine();
                int result;

                bool isNumber = int.TryParse(number, out result);

                if (!isNumber)
                {
                    throw new FormatException("Input must be a number!");
                }
                else if (isNumber)
                {
                    if (result < startNumber || result > endNumber)
                    {
                        throw new IndexOutOfRangeException($"Number is out of range! Must be in range [{startNumber}...{endNumber}]");
                    }
                }

            }
        }
    }
}
