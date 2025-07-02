using myhomework_1_;
using System.Runtime.Intrinsics.X86;
using System.Xml;
using System.Xml.Linq;

internal class Program
{
    static void Main(string[] args)
    {

        // use AsEnumerable() to process employees with status 'Active'.

        List<Employee> employees = new List<Employee>
        {
           new Employee { Name = "Alaa", department = "HR", IsActive = true },
           new Employee { Name = "Nada", department = "IT", IsActive = false }

         };

         var active = employees.AsEnumerable().Where( e => e.IsActive ).ToList();

        foreach (var emp in active)
        {
            Console.WriteLine(emp.Name + " is active in " + emp.department);
        }

        // Use SingleOrDefault to get the only name equal to 100, or null.

        List<student> students = new List<student>
        {
         new student { Name = "Ali", Grade = 85 },
         new student { Name = "Sara", Grade = 92 },
         new student { Name = "John", Grade = 78 }
         };

        var Single = students.SingleOrDefault(s => s.Grade == 100);

        if (Single == null)
        {
            Console.WriteLine("null");
        }
        else
        {
            Console.WriteLine("Student with grade 100 is: " + Single.Name);
        }

        // Use DistinctBy to get unique orders by salary.

        List<Order> orders = new List<Order>
         {
         new Order { Name = "Ali", Salary = 500 },
         new Order { Name = "Salim", Salary = 600 },
         new Order { Name = "muna", Salary = 1000 }, 
         new Order { Name = "mohammed", Salary = 500 }
         };

        var unique = orders.DistinctBy(o => o.Salary).ToList();

        foreach (var order in unique)
        {
            Console.WriteLine(order.Name + " salary: " + order.Salary);
        }

        // Use Max to get the maximum duration from a list of countries.

        List<string> countries = new List<string> { "Egypt", "France", "Egypt", "Italy", "France" };

        int max = countries.Max(c => c.Length);
        Console.WriteLine("Max country name length: " + max);

        var longestCountries = countries.Where(c => c.Length == max).Distinct().ToList();

        foreach (var country in longestCountries)
        {
            Console.WriteLine("Longest country: " + country);
        }

        // Use Min to get the minimum value from a list of students.

        List<student> Students = new List<student>
{
    new student { Name = "Ali", Grade = 85 },
    new student { Name = "Sara", Grade = 92 },


    new student { Name = "John", Grade = 78 }
};

        int min = students.Min(s => s.Grade);
        Console.WriteLine("Minimum grade: " + min);

        var lowestStudents = students.Where(s => s.Grade == min).ToList();

        foreach (var student in lowestStudents)
        {
            Console.WriteLine("Lowest grade student: " + student.Name);
        }

        // Use Distinct to remove duplicate scores.

        List<int> scores = new List<int> { 95, 82, 77, 60, 88, 82, 60 };

        var uniqueScores = scores.Distinct().ToList();
        Console.WriteLine("Unique scores:");
        foreach (var score in uniqueScores)
        {
            Console.WriteLine(score);
        }


    }
}
