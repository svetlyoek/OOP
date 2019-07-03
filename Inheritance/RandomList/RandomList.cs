using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {

        List<string> myList = new List<string>()
        {
             "Ivan",
             "Georgi",
             "Dimitar",
             "Gosho"
        };

        Random myRandom = new Random();

        public string RandomString()
        {
            int index = myRandom.Next(0, this.myList.Count - 1);
            return myList[index];
        }

    }
}
