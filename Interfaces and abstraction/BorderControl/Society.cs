namespace BorderControl
{
    using BorderControl.Exceptions;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public abstract class Society
    {
        private string id;

        protected Society(string id)
        {
            this.Id = id;
        }

        public string Id
        {
            get
            {
                return this.id;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.invalidId);
                }

                this.id = value;
            }
        }
    }
}
