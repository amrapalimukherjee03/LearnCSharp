using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqLab.Model;

namespace LinqLab
{
    internal class LinqObjectList
    {
        public static IList<Employee> getEmployeeList()
        {
            IList<Employee> employee = new List<Employee>
            {
            new Employee{ FirstName="Amrapali", LastName = "Mukherjee", Age=34, Department="IT"},
            new Employee{ FirstName="Amit", LastName = "Singh", Age=34, Department="IT"},
            new Employee{ FirstName="Ayan", LastName = "Bhattachrya", Age=33, Department="HR"},
            new Employee{ FirstName="Banasree", LastName = "Ghosh", Age=32, Department="HR"},
            new Employee{ FirstName="Atrayee", LastName = "Mukherjee", Age=28, Department="IT"},
            new Employee{ FirstName="Arshi", LastName = "Ghosh", Age=32, Department="HR"},
            new Employee{ FirstName="Brishti", LastName = "Mukherjee", Age=20, Department="IT"}
            };
            return employee;
        }

        public static void PrintITEmployees(IList<Employee> employee)
        {
            var ITemployees = from emp in employee
                              where emp.Department.Contains("IT")
                              select emp;
            foreach (Employee emp in ITemployees)
            {
                Console.WriteLine("IT employees:" + emp.FirstName + " " + emp.LastName);
            }
        }

        public static void PrintEmployeesGreater30(IList<Employee> employee)
        {
            var employees = from emp in employee
                            where IsGreater30Age(emp)
                            select new Employee 
                            { 
                                FirstName = emp.FirstName, 
                                LastName = emp.LastName 
                            };
            Console.WriteLine("\nEmployees older than 30:");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.FirstName + " " + emp.LastName);
            }
        }

        public static bool IsGreater30Age(Employee emp)
        {
            return emp.Age > 30;
        }

        public static void PrintEmployeesOrderAge(IList<Employee> employees)
        {
            var ageLowtoHigh = from emp in employees
                               orderby emp.Age
                               select emp;
            var ageHightoLow = from emp in employees
                               orderby emp.Age descending
                               select emp;
            Console.WriteLine("\nEmployees based on Age(High ot Low)");
            foreach (var emp in ageHightoLow)
            {
                Console.WriteLine(emp.FirstName + " " + emp.LastName + " Age:" + emp.Age);
            }

            Console.WriteLine("\nEmployees based on Age(Low of High)");
            foreach (var emp in ageLowtoHigh)
            {
                Console.WriteLine(emp.FirstName + " " + emp.LastName + " Age:" + emp.Age);
            }
        }

        public static void PrintbySameLastName(IList<Employee> employeelist)
        {
            var employeesGrp = from emp in employeelist
                            group emp by emp.LastName;

            Console.WriteLine("\nEmployees of same Lastname:");
            foreach (var empgrp in employeesGrp)
            {
                Console.WriteLine("Lastname: " + empgrp.Key);
                foreach (var emp in empgrp)
                {
                    Console.WriteLine(emp.FirstName + " " + emp.LastName + " Age:" + emp.Age);
                }
            }
        }
    }
}
