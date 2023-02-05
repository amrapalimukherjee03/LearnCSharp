using DependencyInjectionLab.Logger;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionLab
{
    public class PropertyDependency
    {
        private ILogger _ilogger;

        public ILogger iloggerObject
        {
            get { return this._ilogger; }
            set { this._ilogger = value; }
        }
        public void GetPropertyDependency()
        {
            _ilogger.Log("Called from Preporty dependency injection.");
        }
    }
}
