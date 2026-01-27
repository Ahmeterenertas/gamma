using System;

namespace employeeClassProgram
{
    public class Employee
    {
        protected string Name { get; set; }
        protected string Position { get; set; }
        protected double Salary { get; set; }
        protected int Age { get; set; }
        public bool Boss { get; protected set; }

        protected static int GetNum()
        {
            Random random = new Random();
            return random.Next(18, 65);
        }

        protected Employee(string name, string pos, double sal, bool boss)
        {
            Name = name;
            Position = pos;
            Salary = sal;
            Age = GetNum();
            Boss = boss;
        }

        public void PrintInfo()
        {
            Console.WriteLine(
                "Name:{0}, Pos:{1}, Salary:{2}, Age:{3}, Boss:{4}",
                Name, Position, Salary, Age, Boss
            );
        }
    }

    class Employee1 : Employee
    {
        public Employee1() : base("Ahmet", " IT", 99999, false) { }
    }

    class Employee2 : Employee
    {
        public Employee2() : base("Eren", " Politician", 99999, false) { }
    }

    class Employee3 : Employee
    {
        public Employee3() : base("Recep", " HR", 850, false) { }
    }

    class Employee4 : Employee
    {
        public Employee4() : base("Ivedik", " Finance", 1200, false) { }
    }

    class Employee5 : Employee
    {
        public Employee5() : base("Icardi", " Footballer", 1000000, false) { }
    }

    class Employee6 : Employee
    {
        public Employee6() : base("KeremAkt", " Footballer", -100000, false) { }
    }

    class Manager1 : Employee
    {
        public Manager1() : base("Fatih Terim", " Technical Director", 200000, true) { }
    }

    class Manager2 : Employee
    {
        public Manager2() : base("Dursun Ozbek", " CEO", 900000000, true) { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee1();
            Employee e2 = new Employee2();
            Employee e3 = new Employee3();
            Employee e4 = new Employee4();
            Employee e5 = new Employee5();
            Employee e6 = new Employee6();
            Employee m1 = new Manager1();
            Employee m2 = new Manager2();

            e1.PrintInfo();
            e2.PrintInfo();
            e3.PrintInfo();
            e4.PrintInfo();
            e5.PrintInfo();
            e6.PrintInfo();

            Console.WriteLine("\n        Up to the Employee Down to The Manager\n");

            m1.PrintInfo();
            m2.PrintInfo();
        }
    }
}
