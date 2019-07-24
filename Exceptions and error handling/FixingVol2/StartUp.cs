namespace FixingVol2
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            byte result = 0;
            int firstNumber = 30;
            int secondNumber = 60;

            try
            {
                result = Convert.ToByte(firstNumber * secondNumber);

                Console.WriteLine($"{firstNumber} x {secondNumber} = {result}");
                Console.ReadLine();
            }
            catch (OverflowException oe)
            {

                throw new OverflowException($"Result is out of {result.GetType().Name} range!");
            }
        }
    }
}
