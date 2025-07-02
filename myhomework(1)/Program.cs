using myhomework_1_;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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

        // Use Last to find the last name ending with 'z'.

        List<string> names = new List<string> { "Mona", "Ahmedz", "Mahmoud", "Salma" };

        var last = names.Where(n =>n.EndsWith("z")).Last();

        if (last == null)
        {
            Console.WriteLine("No name ends with 'z'");
        }
        else
        {
            Console.WriteLine("Last name ending with 'z': " + last);
        }

        //Use LastOrDefault to safely get the last product with grade above 90

        List<Product> products = new List<Product>
           {
             new Product { Name = "Phone", Price = 200 },
             new Product { Name = "Book", Price = 30 },
             new Product { Name = "Laptop", Price = 1000 }
           };
        var lastOrDefault = products.LastOrDefault(p => p.Price > 90);
        if (lastOrDefault == null)
        {
            Console.WriteLine("No product above 90");
        }
        else
        {
            Console.WriteLine("Last product  above 90: " + lastOrDefault.Name);
        }

        // Use ToList() to convert employees starting with 'A' into a List.

        List<Employee> Employees = new List<Employee>
         {
         new Employee { Name = "Alaa", department = "HR" },
         new Employee { Name = "Nada", department = "IT" }
         };

        var employee = Employees.Where(e => e.Name.StartsWith("A")).ToList();
        Console.WriteLine("Employees starting with 'A':");


        // Use Single to find the only name with grade above 90.

        var single = students.Single(s => s.Grade > 90);
        Console.WriteLine("Single student with grade above 90: " + single.Name);



        // Use ToArray() to convert orders with price above 100 into an Array.

        List<Product>Products = new List<Product>
        {
       new Product { Name = "Phone", Price = 200 },
       new Product { Name = "Book", Price = 30 },
       new Product { Name = "Laptop", Price = 1000 }
        };
        var productArray = Products.Where(p => p.Price > 100).ToArray();
        Console.WriteLine("Products with price above 100:");

        // Use Average to calculate the average Grade of students.

        List<student> StudentsList = new List<student>
        {
            new student { Name = "Ali", Grade = 85 },
            new student { Name = "Sara", Grade = 92 },
            new student { Name = "John", Grade = 78 }
        };
       var averageGrade = StudentsList.Average(s => s.Grade);
        Console.WriteLine("Average grade: " + averageGrade);

        //Use AsQueryable() to filter words by longer than 5 characters.

        List<string> words = new List<string> { "apple", "banana", "cherry", "date", "elderberry" };
        var longWords = words.AsQueryable().Where(w => w.Length > 5).ToList();
        Console.WriteLine("Words longer than 5 characters:");
        foreach (var word in longWords)
        {
            Console.WriteLine(word);
        }

        // Use First to find the first name from department 'HR'.

        List<Employee> employeeList = new List<Employee>
        {
            new Employee { Name = "Alaa", department = "HR", IsActive = true },
            new Employee { Name = "Nada", department = "IT", IsActive = false }
        };
        var firstHR = employeeList.First(e => e.department == "HR");
        Console.WriteLine("First employee in HR: " + firstHR.Name);

        // Use FirstOrDefault to find the first email greater than 50, or return default.

        List<string> emails = new List<string> 
        {  "ali1990@gmail.com",
           "sarasalem@egmail.com",
           "John.moha@gmail.com",
         };

        var Email = emails.FirstOrDefault(e => e.Length > 50).ToList();
        if(Email.Any())

        {
            Console.WriteLine("First email longer than 50 characters: " + Email);
        }
        else
        {
            Console.WriteLine("No email found with more than 50 characters.");
        }


    }
}
