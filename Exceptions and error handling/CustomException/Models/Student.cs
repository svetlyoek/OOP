namespace CustomException.Models
{
    using CustomException.Exceptions;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Student
    {
        private string name;

        public Student(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }
        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (Char.IsDigit(value[i]) || Char.IsSymbol(value[i]))
                    {
                        throw new InvalidPersonNameException();
                    }
                }

                this.name = value;
            }
        }

        public string Email { get; private set; }
    }
}
