using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myhomework_1_
{
    internal class student
    {
         public string Name { get; set;}
        public int Grade { get; set;}

    }
    public class Item
    {
        public int Id { get; set;}
        public string Name { get; set;}
    }
    public class User
    {
        public string Name { get; set;}
        public bool IsActive { get; set;}
    }
    public class Product
    {
        public string Name { get; set;}
        public decimal Price { get; set;}
    }
    public class Employee
    {
        public string Name { get; set;}
        public string department { get; set;}

        public bool IsActive { get; set;}

        
    }
    public class Order
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }

}

