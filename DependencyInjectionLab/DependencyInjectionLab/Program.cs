using DependencyInjectionLab.Logger;
using System;

namespace DependencyInjectionLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Constructor dependency:");
            ILogger concreteLogger = new ConsoleLogger();
            ConstructorDependency constructorDependency = new ConstructorDependency(concreteLogger);
            constructorDependency.GetConstructorName();

            Console.WriteLine("Method dependency:");
            ILogger concreteLoggerMethod = new FileLogger();
            MethodDependency methodDependency = new MethodDependency();
            methodDependency.GetMethodName(concreteLoggerMethod);

            Console.WriteLine("Property dependency:");
            ILogger concreteLoggerproperty = new FileLogger();
            PropertyDependency propDependency = new PropertyDependency();
            propDependency.iloggerObject= concreteLoggerproperty;
            propDependency.GetPropertyDependency();


        }
    }
}
