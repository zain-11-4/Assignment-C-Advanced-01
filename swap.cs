using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_C__Advanced_01
{
    internal class swap
    {
        public  void swap1 <T>(ref T a, ref T b)
        {
            T Temp = a;
            a = b;
            b = Temp;
        }
        
    }
}
