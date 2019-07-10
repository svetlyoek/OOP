namespace Telephony
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Smartphone : ICall, IBrowse
    {
        private string number;
        private string url;

        public string Number
        {
            get
            {
                return this.number;
            }
            set
            {
                if (CheckNumber(value))
                {
                    throw new ArgumentException(ExceptionMessages.invalidNumber);
                }

                this.number = value;
            }
        }


        public string Url
        {
            get
            {
                return this.url;
            }

            set
            {
                if (CheckUrl(value))
                {
                    throw new ArgumentException(ExceptionMessages.invalidUrl);
                }

                this.url = value;
            }

        }

        private bool CheckUrl(string value)
        {
            return value.FirstOrDefault(u => Char.IsDigit(u)) != 0;
        }

        private bool CheckNumber(string value)
        {
            return value.FirstOrDefault(n => !Char.IsDigit(n)) != 0;
        }


        public string CallNumber()
        {
            return $"Calling... {this.Number}";
        }

        public string PrintUrl()
        {
            return $"Browsing: {this.Url}!";
        }
    }
}
