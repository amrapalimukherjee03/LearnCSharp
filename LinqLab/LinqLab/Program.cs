// See https://aka.ms/new-console-template for more information
using LinqLab;
using LinqLab.LearnLINQ;
using LinqLab.Model;
using System.Diagnostics.Metrics;

Console.WriteLine("Learn LINQ");
//Linq for Array
Console.WriteLine("Linq from Array: ");
LinqArray.PrintCountry();

IList<Employee> empList = LinqObjectList.getEmployeeList();
//LINQ for Object List
Console.WriteLine("\nLinq from Object List: ");
LinqObjectList.PrintITEmployees(empList);

//LINQ using Method
LinqObjectList.PrintEmployeesGreater30(empList);

//LINQ orderby Ascending and descending
LinqObjectList.PrintEmployeesOrderAge(empList);

//LINQ GroupBy
LinqObjectList.PrintbySameLastName(empList);

//LINQ JOIN
LinqJoin.GetCompanyName();

//LINQ Method
LINQMethods.LearnBasicSkip();
LINQMethods.SecondhighestAge();
LINQMethods.LearnBasicTake();
LINQMethods.Top2oldestEmployee();

//LINQ operators
LinqJoin.LearnUnion();
LinqJoin.LearnExcept();
LinqJoin.LearnDistinct();
LinqJoin.LearnIntersect();