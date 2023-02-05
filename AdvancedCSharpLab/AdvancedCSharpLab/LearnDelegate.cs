using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpLab
{
    public delegate void del1(string text);
    internal static class LearnDelegate
    {
        public static void MethodA(string text)
        {
            Console.WriteLine("Called MethodA. " + text);
        }

        public static void MethodB(string text)
        {
            Console.WriteLine("Called MethodB. " + text);
        }
    }
}
