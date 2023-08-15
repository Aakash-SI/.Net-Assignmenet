using System;

namespace EmployeeHierarchy
{
    abstract class Employee
    {
        public string Name { get; }
        public string Employee_ID { get; }
        public double Salary { get; }

        public Employee(string name, string employeeID, double salary)
        {
            Name = name;
            Employee_ID = employeeID;
            Salary = salary;
        }

        public abstract double Calculate_Bonus();

        public virtual void Display_Details()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Employee ID: {Employee_ID}");
            Console.WriteLine($"Salary: ${Salary}");
        }
    }

    class Manager : Employee
    {
        public Manager(string name, string employee_ID, double salary)
            : base(name, employee_ID, salary)
        {
        }

        public override double Calculate_Bonus()
        {
            return Salary * 0.1;
        }

        public override void Display_Details()
        {
            base.Display_Details();
            Console.WriteLine($"Calculated Bonus: ${Calculate_Bonus():F2}");
        }
    }

    class Developer : Employee
    {
        public Developer(string name, string employeeID, double salary)
            : base(name, employeeID, salary)
        {
        }

        public override double Calculate_Bonus()
        {
            return Salary * 0.08;
        }

        public override void Display_Details()
        {
            base.Display_Details();
            Console.WriteLine($"Calculated Bonus: ${Calculate_Bonus():F2}");
        }
    }

    class Sales_Person : Employee
    {
        public Sales_Person(string name, string employee_ID, double salary)
            : base(name, employee_ID, salary)
        {
        }

        public override double Calculate_Bonus()
        {
            return Salary * 0.05;
        }

        public override void Display_Details()
        {
            base.Display_Details();
            Console.WriteLine($"Calculated Bonus: ${Calculate_Bonus():F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager("M", "M1", 50000);
            Developer d = new Developer("D", "D1", 60000);
            Sales_Person s = new Sales_Person("S", "S1", 45000);

            m.Display_Details();
            Console.WriteLine();
            d.Display_Details();
            Console.WriteLine();
            s.Display_Details();
        }
    }
}
