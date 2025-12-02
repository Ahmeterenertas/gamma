using System;
using System.Collections.Generic;

class Student
{
	public string Name;
	public string Faculty;
	public int Grade;

	public Student(string name, string faculty, int grade)
	{
		this.Name = name;
		this.Faculty = faculty;
		this.Grade = grade;
	}
}

class Program
{
	static void Main()
	{
		var randomgrade = new Random();

		var students = new List<Student>();

		students.Add(new Student("Ahmet Eren Ertas", "Bilgisayar Engineer", randomgrade.Next(0, 101)));
		students.Add(new Student("Taha Yasin Inan", "Hukuk Fac", randomgrade.Next(0, 101)));
		students.Add(new Student("Berat Samil Dursun", "Yazilim Engineer", randomgrade.Next(0, 101)));
		students.Add(new Student("Batuhan Bezci", "Yabanci Diller Fac", randomgrade.Next(0, 101)));
		students.Add(new Student("Yusuf Kaan Celiktas", "Iktisat Fac", randomgrade.Next(0, 101)));

		int totalGradeSum = 0;
		int maxGrade = -1;
        var studentCount = students.Count;
        var defaultOrderList = new List<Student>(students);

        Console.WriteLine("-------------------------------------------------------");
		Console.WriteLine("------------ STUDENTS LIST (DEFAULT ORDER) ------------");
		Console.WriteLine("-------------------------------------------------------");
		Console.WriteLine("{0,-25} {1,-25} {2,-25}", "Name Surname", "Faculty", "Grade");
		Console.WriteLine("-------------------------------------------------------");

		foreach (var std in defaultOrderList)
		{
			Console.WriteLine("{0,-25} {1,-25} {2,-25}", std.Name, std.Faculty, std.Grade);
			totalGradeSum += std.Grade;
			if (std.Grade > maxGrade)
			{
				maxGrade = std.Grade;
			}
		}

        var averageGrade = (double)totalGradeSum / studentCount;

        Console.WriteLine("-------------------------------------------------------");
		Console.WriteLine("Total Number Of Students: " + studentCount);
		Console.WriteLine("Total Grade: " + totalGradeSum);
		Console.WriteLine("Average Grade: " + averageGrade);
		Console.WriteLine("Best Grade: " + maxGrade);
		Console.WriteLine("-------------------------------------------------------");


        students.Sort((a, b) => a.Name.CompareTo(b.Name));

		Console.WriteLine("-------------------------------------------------------");
		Console.WriteLine("------- STUDENTS LIST (ALPHABETICALLY SORTED) ---------");
		Console.WriteLine("-------------------------------------------------------");
		Console.WriteLine("{0,-25} {1,-25} {2,-25}", "Name Surname", "Faculty", "Grade");
		Console.WriteLine("-------------------------------------------------------");

		foreach (var std in students)
		{
			Console.WriteLine("{0,-25} {1,-25} {2,-25}", std.Name, std.Faculty, std.Grade);
		}
		Console.WriteLine("-------------------------------------------------------");


        students.Sort((a, b) => b.Grade.CompareTo(a.Grade));

		Console.WriteLine("-------------------------------------------------------");
		Console.WriteLine("---------- STUDENTS LIST (GRADE DESCENDING) -----------");
		Console.WriteLine("-------------------------------------------------------");
		Console.WriteLine("{0,-25} {1,-25} {2,-25}", "Name Surname", "Faculty", "Grade");
		Console.WriteLine("-------------------------------------------------------");

		foreach (var std in students)
		{
			Console.WriteLine("{0,-25} {1,-25} {2,-25}", std.Name, std.Faculty, std.Grade);
		}
		Console.WriteLine("-------------------------------------------------------");
	}
}