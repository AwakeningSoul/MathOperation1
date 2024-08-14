using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperation1
{
    class MathOperation1
    {
        //Create a method that takes two integers as parameters
        //Make one paramater optional by providing a default value
        public int MathOperation(int i, int j = 1)
        {
            //Perform multiplication on integers and return the result
            int result = i * j;
            return result;
        }
    }
}
