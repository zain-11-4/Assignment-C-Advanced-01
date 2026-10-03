using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_C__Advanced_01
{
    internal class Container<T>
    {
        private readonly List<T> _values = [];
        public void  Add(T value)
        {
            _values.Add(value);
        }

        public void get()
        {
            foreach (var n in _values)
            {
                Console.WriteLine(n);
            }
        }










    }
}
