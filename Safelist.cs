using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_C__Advanced_01
{
    internal class Safelist <T>
    {
        private readonly  List<T> safelist = [];

        public void add(T item)
        {
            safelist.Add(item); 
        }

        public T get(int index)
        {
            if (index < 0)
            {
                return default;
            }
            else
            {
                return safelist[index];
            }
        }

    }
}
