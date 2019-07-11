namespace CollectionHierarchy.Models
{
    using CollectionHierarchy.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public abstract class Collection : IAddCollection
    {
        public Collection()
        {
            this.Data = new List<string>();
        }

        public List<string> Data { get; }

        public virtual int Add(string item)
        {
            this.Data.Insert(0, item);
            return 0;
        }
    }
}
