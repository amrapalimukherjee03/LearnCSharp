using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqLab.Model;

namespace LinqLab
{
    internal class LinqJoin
    {
        private static readonly List<string> numbers1 = new List<string>() { "One", "Two", "Three", "Four", "Five" };
        private static readonly List<string> numbers2 = new List<string>() { "One", "Seven", "Nine", "Four", "Five" };

        public static IList<Employee> employee = new List<Employee>
            {
            new Employee{ FirstName="Amrapali", LastName = "Mukherjee", Age=34, CompanyID=10},
            new Employee{ FirstName="Amit", LastName = "Singh", Age=34, CompanyID=10},
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

        #region LearnLINQJoin
        public static void GetCompanyName()
        {
            var empdetails = from emp in employee
                             join comp in company
                             on emp.CompanyID equals comp.CompanyID
                             select new
                             {
                                 comp.CompanyName,
                                 EmployeeName = emp.FirstName + " " + emp.LastName
                             };

            Console.WriteLine("\nLINQ join:");

            foreach (var emp in empdetails)
            {
                Console.WriteLine("Employee " + emp.EmployeeName + " Belongs to " + emp.CompanyName);
            }
        }
        #endregion

        #region learnIntersect

        public static void LearnIntersect()
        {
            var result = numbers1.Intersect(numbers2);
            Console.WriteLine("Intersected values are:");
            foreach (var res in result) { Console.WriteLine(res); }
        }
        #endregion 

        #region learnUnion

        public static void LearnUnion()
        {
            var result = numbers1.Union(numbers2);
            Console.WriteLine("Union values are:");
            foreach (var res in result) { Console.WriteLine(res); }
        }
        #endregion 

        #region learnExcept

        public static void LearnExcept()
        {
            var result = numbers1.Except(numbers2);
            Console.WriteLine("List 1 except List 2 values are:");
            foreach (var res in result) { Console.WriteLine(res); }
        }
        #endregion

        #region learnExcept

        public static void LearnDistinct()
        {
            var result = numbers1.Distinct();
            Console.WriteLine("Distinct values are:");
            foreach (var res in result) { Console.WriteLine(res); }
        }
        #endregion
    }
}
