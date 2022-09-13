using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    internal class Method
    {
        public static int Add(int one, int two)
        {
            return one + two;
        }

        public static int Subtract(int one, int two)
        {
            return two - one;
        }

        public static int Multiply(int one, int two)
        {
            return one * two;
        }

        public static int Divide(int one, int two)
        {
            return two / one;
        }

        public static int Module(int two, int five)
        {
            return five % two;
        }
    }
}
