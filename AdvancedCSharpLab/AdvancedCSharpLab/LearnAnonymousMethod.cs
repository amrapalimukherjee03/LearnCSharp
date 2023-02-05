using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpLab
{
    delegate void del2();
    internal class LearnAnonymousMethod
    {
        public void LearnAnonymous()
        {
            del2 del2instance = delegate()
            {
            Console.WriteLine("Anonymous method called");
            };
            del2instance.Invoke();
        }
    }
}
