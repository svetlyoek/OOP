﻿using System;

namespace Telephony
{
    public class StartUp
    {
        private static void Main()
        {
            var phoneNumbers = Console.ReadLine().Split();
            var webAddress = Console.ReadLine().Split();

            PrintNumbers(phoneNumbers);

            PrintUrls(webAddress);
        }

        private static void PrintUrls(string[] webAddress)
        {
            foreach (var address in webAddress)
            {
                try
                {
                    Smartphone smartPhone = new Smartphone { Url = address };
                    Console.WriteLine(smartPhone.PrintUrl());
                }
                catch (ArgumentException message)
                {
                    Console.WriteLine(message.Message);
                }
            }
        }

        private static void PrintNumbers(string[] phoneNumbers)
        {
            foreach (var phoneNumber in phoneNumbers)
            {
                try
                {
                    Smartphone smartPhone = new Smartphone { Number = phoneNumber };
                    Console.WriteLine(smartPhone.CallNumber());
                }
                catch (ArgumentException message)
                {
                    Console.WriteLine(message.Message);
                }
            }
        }
    }
}
