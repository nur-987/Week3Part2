using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWithEvents
{
    /// <summary>
    /// hide the actual funtions from operations class
    /// this should be the place to perform the func.
    /// only he doesnt know what the functions are
    /// </summary>
    class Operations
    {
        public void performOperations(int a, int b, MyDelegate myDelegate)
        {
            myDelegate(a, b);
        }
    }
}
