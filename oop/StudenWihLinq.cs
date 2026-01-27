using System;
using System.Collections.Generic;

namespace Csharpders
{
    //--------
    public class Employee
    {
        private string name;
        private string position;
        private double salary;
        private int age;
        private bool boss;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        
        public  bool Boss
        {
            get { return boss; }
            set { boss = value; }
        }

        static int getNum()
        {
            Random random = new Random();
            return random.Next(18, 60);
        }

        public Employee(string pname, string pposition, double psalary)
        {
            name = pname;
            position = pposition;
            salary = psalary;
            age = getNum();
            boss = false;
        }
        
        public virtual void SetRise(double percent)
        {
            salary = Salary*(1.0+percent/100.0);
        }
        
        public static void ShowEmployess(List<Employee> employees)
        {
        foreach (Employee emp in employees)
            {
                string type = emp.GetType().ToString();
                int pos = type.IndexOf('.');
				type = type.Substring(pos+1,5);
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", emp.Name, emp.Position, Math.Round(emp.Salary,2), emp.Age, type);
            }
        }
    } //The end of class Employee
    
    //------------

    public class Manager : Employee
    {   
        public Manager (string pname, string pposition, double psalary, string ptitle) : base(pname, pposition, psalary)
        {
            Boss = true;
            Title = ptitle;
        }
        
        private string title;
        
        public  string Title
        {
            get { return title; }
            set { title = value; }
        }
        
        public override void SetRise(double percent)
        {
            Salary = Salary*(1.0+percent/100.0);
            Salary += 2000;
        }
        
    } //The end of class Manager


    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Taha", "IT Engineer", 15000));
            employees.Add(new Employee("Emir", "Military", 80000));
            employees.Add(new Employee("Ayşe", "Doctor  ", 50000));
            employees.Add(new Employee("Mehmet", "Teacher  ", 20000));
            employees.Add(new Employee("Elif", "Designer", 30000));
            Manager manager = new Manager("Adam", "Designer", 80000, "CEO");
            employees.Add(manager);
            
            //List<Manager> managers = new List<Manager>();
            
            
            Console.WriteLine("\n\n-------------The list of employees------------\n");
            Employee.ShowEmployess(employees);
            
             foreach (Employee emp in employees)
             {
                 emp.SetRise(20);
             }
             
            Console.WriteLine("\n--------------After a 20% rise--------------\n");
            Employee.ShowEmployess(employees);
            
            Console.WriteLine("\n--------------Info about Manager--------------\n");
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", manager.Name, manager.Position, Math.Round(manager.Salary,2), manager.Age, manager.Title);
        }// The end of Main
            
    } // The end of class Program
}
