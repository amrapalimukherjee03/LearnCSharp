using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionLab.Logger
{
    internal class FileLogger : ILogger
    {
        void ILogger.Log(string text)
        {
            Console.WriteLine("In File Logger. " + text);
        }
    }
}
