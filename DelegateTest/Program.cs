internal class Program
{
    static void Main(string[] args)
    {


        List<Employee> employees = new List<Employee>();
        employees.Add(new Employee() { ID = 101, Name = "Mark", Salary = 5000, Experience = 5 });
        employees.Add(new Employee() { ID = 102, Name = "John", Salary = 4000, Experience = 4 });
        employees.Add(new Employee() { ID = 103, Name = "Mary", Salary = 6000, Experience = 6 });
        employees.Add(new Employee() { ID = 104, Name = "Steve", Salary = 3000, Experience = 3 });
        employees.Add(new Employee() { ID = 105, Name = "Pam", Salary = 7000, Experience = 7 });



        Employee.PromoteEmployee(employees, emp => emp.Experience >= 5);

    }
}

delegate bool IsPromotable(Employee empl);

class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }


    public static void PromoteEmployee(List<Employee> employees, IsPromotable IsEligible)
    {
        foreach (Employee employee in employees)
        {
            if (IsEligible(employee)) Console.WriteLine(employee.Name + " Promoted");
        }
    }
}