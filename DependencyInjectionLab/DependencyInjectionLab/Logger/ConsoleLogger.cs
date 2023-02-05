using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionLab.Logger
{
    internal class ConsoleLogger : ILogger
    {
        public void Log(string text)
        {
            Console.WriteLine("In Console Logger. " + text);
        }
    }
}
