using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpLab
{
    public class LearnExtensionMethod
    {
        public void MathodA()
        {
            Console.WriteLine("MethodA called.");
        }
        public void MathodB()
        {
            Console.WriteLine("MethodB called.");
        }
    }
    public static class ExtendedClass
    {
        public static void MathodC(this LearnExtensionMethod learnExtensionMethod)
        {
            Console.WriteLine("MethodC called.");
        }
    }

}
