using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpLab
{
    internal class LearnPredicate
    {
        public void PredicateExecute()
        {
            Predicate<int> pred = MethodGreaterThan10;
            bool result = pred(3);
            Console.WriteLine("Called predicate. " + result);
        }

        private bool MethodGreaterThan10(int obj)
        {
            return obj > 10;
        }
    }
}
