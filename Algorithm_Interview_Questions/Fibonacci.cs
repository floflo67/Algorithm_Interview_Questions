using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Interview_Questions
{
    class Fibonacci
    {
        /*Fibonacci is the suite:
         * 0; 1; 1; 2; 3; 5; etc...
         * you have u(n) = u(n-1) + u(n-2)
         * with u(0) = 0 and u(1) = 1
         */

        /// <summary>
        /// Construction by recurrence
        /// The easiest and fastest way to do it
        /// </summary>
        /// <param name="value">The index</param>
        /// <returns>The fibonacci number at the index "value"</returns>
        public int Recurrence(int value)
        {
            if(value == 0)
                return 0;
            if(value == 1)
                return 1;
            return (Recurrence(value - 1) + Recurrence(value - 2));
        }
    }
}
