﻿namespace Fixing
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] weekdays = new string[5];

            weekdays[0] = "Sunday";
            weekdays[1] = "Monday";
            weekdays[2] = "Tuesday";
            weekdays[3] = "Wednesday";
            weekdays[4] = "Thursday";

            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(weekdays[i].ToString());
                }

                Console.ReadLine();
            }
            catch (IndexOutOfRangeException iofre)
            {

                throw new IndexOutOfRangeException("Invalid day!", iofre);
            }

        }
    }
}
