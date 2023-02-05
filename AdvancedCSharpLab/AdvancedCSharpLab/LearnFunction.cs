using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpLab
{
    internal class LearnFunction
    {
        public void FunctionLearn()
        {
            Func<int, int, int> result = add;
            int outputresolt = result(10, 20);
            Console.WriteLine("Function used. Result addition is: " + outputresolt);
            result = multiply;
            outputresolt = result(10, 20);
            Console.WriteLine("Function used. Result Multiplication is: " + outputresolt);
        }

        private int multiply(int arg1, int arg2)
        {
            return arg1 * arg2;
        }

        private int add(int arg1, int arg2)
        {
            return arg1 + arg2;
        }
    }
}
