namespace employeeClassProgram
{

    public class Employee
    {
        public string _name;
        public string _position;
        public double _salary;
        public int _age;


        static int getNum()
        {
            Random random = new Random();
            int number;
            number = random.Next(1, 101);
            return number;
        }

        public Employee(string name, string pos, double sal)
        {
            _name = name;
            _position = pos;
            _salary = sal;
            _age = getNum();
        }
    }





    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");

            Employee employee1 = new("Berat", "IT", 99999);
            Employee employee2 = new("Taha", "IT", 999999);
            Employee employee3 = new("Ahmet", "IT", 009999999);

            Console.WriteLine("Name:{0}, Pos:{1} salary:{2}, {3} ", employee3._name, employee3._position, employee3._salary, employee3._age);
            Console.WriteLine("Name:{0}, Pos:{1} salary:{2}, {3} ", employee1._name, employee1._position, employee1._salary, employee1._age);
            Console.WriteLine("Name:{0}, Pos:{1} salary:{2}, {3} ", employee2._name, employee2._position, employee2._salary, employee2._age);


        }
    }



}