namespace StudentSystem
{
    using System;
    using System.Collections.Generic;

    public class StudentSystem
    {
        private Dictionary<string, Student> students;
        public StudentSystem()
        {
            this.students = new Dictionary<string, Student>();
        }

        public void AddStudent(string name, int age, double grade)
        {
            if (!this.students.ContainsKey(name))
            {
                var student = new Student(name, age, grade);
                this.students[name] = student;
            }
        }

        public void PrintStudent(string name)
        {
            if (this.students.ContainsKey(name))
            {
                var student = this.students[name];
                Console.WriteLine(student);
            }
        }

        public void EndProgram()
        {
            Environment.Exit(0);
        }

        public void InputCheck()
        {
            string[] lines = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string command = lines[0];

            if (command == "Create")
            {
                var name = lines[1];
                var age = int.Parse(lines[2]);
                var grade = double.Parse(lines[3]);

                AddStudent(name, age, grade);
            }

            else if (command == "Show")
            {
                var name = lines[1];

                PrintStudent(name);
            }

            else if (command == "Exit")
            {
                EndProgram();
            }

        }
    }
}

public class Student
{
    public Student(string name, int age, double grade)
    {
        this.Name = name;
        this.Age = age;
        this.Grade = grade;
    }
    public double Grade { get; private set; }

    public int Age { get; private set; }

    public string Name { get; private set; }

    public override string ToString()
    {

        var studentInfo = $"{this.Name} is {this.Age} years old.";

        if (this.Grade >= 5.00)
        {
            studentInfo += " Excellent student.";
        }
        else if (this.Grade < 5.00 && this.Grade >= 3.50)
        {
            studentInfo += " Average student.";
        }
        else
        {
            studentInfo += " Very nice person.";
        }

        return studentInfo.ToString();
    }

}
