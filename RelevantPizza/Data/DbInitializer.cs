using RelevantPizza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelevantPizza.Data
{
    public class DbInitializer
    {
        public static void Initialize(PizzaContext context)
        {
            context.Database.EnsureCreated();

            if (context.Employees.Any())
            {
                return;
            }

            Employee[] employees = new Employee[]
            {
                new Employee{FirstName = "John", LastName = "Cornishon", PhoneNumber = "123123", Role = Roles.Manager, Salary = 100000 },
                new Employee{FirstName = "John", LastName = "Cornishon", PhoneNumber = "123123", Role = Roles.Manager, Salary = 100000 }
            };

         
            context.Employees.AddRange(employees);
            context.SaveChanges();
            
        }
    }
}
