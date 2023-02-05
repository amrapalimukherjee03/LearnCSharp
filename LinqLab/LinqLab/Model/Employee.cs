namespace LinqLab.Model
{
    internal class Employee
    {
        public string? FirstName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Department { get; set; } = string.Empty;
        public int? CompanyID { get; set; }

    }
}