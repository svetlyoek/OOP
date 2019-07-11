namespace CollectionHierarchy.Models
{
    using CollectionHierarchy.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class AddCollection : Collection
    {
        public AddCollection()
        {
        }

        public override int Add(string item)
        {
            base.Add(item);
            return base.Data.Count - 1;
        }
    }
}
