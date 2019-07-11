namespace BirthdayCelebrations.Models
{
    using BirthdayCelebrations.Exceptions;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Robot : Society
    {
        private string model;

        public Robot(string model, string id)
            : base(id)
        {
            this.Model = model;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.invalidModel);
                }

                this.model = value;
            }
        }
    }
}
