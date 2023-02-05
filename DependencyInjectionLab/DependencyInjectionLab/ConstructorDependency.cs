using DependencyInjectionLab.Logger;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionLab
{
    public class ConstructorDependency
    {
        //Constructor dependency
        private ILogger _ilogger;
        public ConstructorDependency(ILogger ilogger)
        { 
            _ilogger = ilogger;
        }
        public void GetConstructorName()
        {
            _ilogger.Log("Called from Methohd dependency injection.");
        }
    }
}
