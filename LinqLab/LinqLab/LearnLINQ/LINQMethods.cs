using LinqLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab.LearnLINQ
{
    internal class LINQMethods
    {
        private static List<string> numbers = new List<string>() { "One", "Two", "Three", "Four", "Five" };

        public static IList<Employee> employee = new List<Employee>
            {
            new Employee{ FirstName="Amrapali", LastName = "Mukherjee", Age=34, CompanyID=10},
            new Employee{ FirstName="Amit", LastName = "Singh", Age=39, CompanyID=10},
            new Employee{ FirstName="Ayan", LastName = "Bhattachrya", Age=33, CompanyID=30},
            new Employee{ FirstName="Banasree", LastName = "Ghosh", Age=32, CompanyID=20},
            new Employee{ FirstName="Atrayee", LastName = "Mukherjee", Age=28, CompanyID=10},
            new Employee{ FirstName="Arshi", LastName = "Ghosh", Age=32, CompanyID=20},
            new Employee{ FirstName="Brishti", LastName = "Mukherjee", Age=20, CompanyID=40}
            };

        public static IList<Company> company = new List<Company>
            {
            new Company{ CompanyName="LHVG", CompanyType="Institution",CompanyID=10},
            new Company{ CompanyName="Job Search ltd", CompanyType="Recruitment",CompanyID=20},
            new Company{ CompanyName="Computer vision ltd", CompanyType="IT",CompanyID=30},
            new Company{ CompanyName="Programming ltd", CompanyType="IT",CompanyID=40}
            };

        #region LearnSkip
        public static void LearnBasicSkip()
        {
            List<string> selectedNumber = numbers.Skip(2).ToList();
            Console.WriteLine("Skipped 2 elements:");

            foreach (string number in selectedNumber)
            {
                Console.WriteLine(number);
            }
        }

        public static void SecondhighestAge()
        {
            Console.WriteLine("Second oldest employee is : ");
            var secondOldestEmployee = (from emp in employee
                                        orderby emp.Age descending
                                        select emp).Skip(1).FirstOrDefault();
            if (secondOldestEmployee != null)
            {
                Console.WriteLine(secondOldestEmployee.FirstName + " " + secondOldestEmployee.LastName);
                Console.WriteLine("Age is: " + secondOldestEmployee.Age);
            }
            else
            {
                Console.WriteLine("Not applicable");
            }

        }
        #endregion

        #region LearnTake
        public static void LearnBasicTake()
        {
            List<string> selectedNumber = numbers.Take(2).ToList();
            Console.WriteLine("Take 2 elements:");

            foreach (string number in selectedNumber)
            {
                Console.WriteLine(number);
            }
        }

        public static void Top2oldestEmployee()
        {
            Console.WriteLine("Top 2 oldest employees are : ");
            var secondOldestEmployee = (from emp in employee
                                        orderby emp.Age descending
                                        select emp).Take(2).ToList();

            foreach (var emp in secondOldestEmployee)
            {
                Console.WriteLine(emp.FirstName + " " + emp.LastName);
                Console.WriteLine("Age is: " + emp.Age);
            }
        }
        #endregion

        #region LearnTakeWhile
        public static void GetEmployeesFirst5()
        {
            Console.WriteLine("Elements with 3 letters or less: ");
            var numberList = numbers.TakeWhile(s => s.Length <= 3);
            foreach (var numb in numberList)
            {
                Console.WriteLine(numb);
            }
        }
        #endregion
    }
}

