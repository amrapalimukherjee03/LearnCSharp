using DependencyInjectionLab.Logger;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionLab
{
    public class MethodDependency
    {
        public void GetMethodName(ILogger ilogger)
        {
            ilogger.Log("Called from Methohd dependency injection.");
        }
    }
}
