using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingListApp
{
    class Data
    {
        List<string> items = new List<string>();

        public IEnumerable<string> Items => items.ToArray();

        public void Add(string s)
        {
            items.Add(s);
        }
    }
}
