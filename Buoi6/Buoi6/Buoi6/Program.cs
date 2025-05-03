using System;

namespace Buoi6
{

    public interface IEmployee
    {
        int calculateSalary();
        string name { get; set; }
    }

    public class Employee : IEmployee
    {
        public string name { get; set; }
        public int paymentPerHour { get; set; }

        public Employee(string name, int paymentPerHour)
        {
            this.name = name;
            this.paymentPerHour = paymentPerHour;
        }

        public int calculateSalary()
        {
            return this.paymentPerHour *20;
        }
    }


    public class PartTimeEmployee : Employee
    {
        public int workingHours{ get; set; }

        public PartTimeEmployee(string name, int paymentPerHour, int workingHours)
            : base(name, paymentPerHour)
        {
            this.workingHours = workingHours;
        }

        public int calculateSalary()
        {
            return workingHours * this.paymentPerHour;
        }
    }

    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string name, int paymentPerHour)
            : base(name, paymentPerHour)
        {
        }

        public int calculateSalary()
        {
            return paymentPerHour * 20;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create part-time and full-time employees
            PartTimeEmployee partTime = new PartTimeEmployee("John Doe", 15, 20);
            FullTimeEmployee fullTime = new FullTimeEmployee("Jane Smith", 20);

            // Output their salaries
            Console.WriteLine($"{partTime.name} (Part-Time): ${partTime.calculateSalary()}");
            Console.WriteLine($"{fullTime.name} (Full-Time): ${fullTime.calculateSalary()}");
        }
    }
}
