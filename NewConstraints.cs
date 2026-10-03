using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_C__Advanced_01
{
    internal class NewConstraints <T> where T : StructConstraints<int>, new() 
    {
        // not error Beacuse StructConstraints Class Not have any constructor
    }
}
