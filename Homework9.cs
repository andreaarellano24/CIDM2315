using System;
using System.Collections.Generic;

namespace Homework9;

class Student
{
    private int studentID;
    private string studentName;

    public static List<Student> studentList = new List<Student>();

    public Student(int id, string name)
    {
        studentID = id;
        studentName = name;
        studentList.Add(this);
    }

    public void PrintInfo()
    {
        Console.WriteLine("Student ID: " + studentID + ", Student Name: " + studentName);
    }
    public string GetName()
    {
        return studentName;
    }

}

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student(111, "Alice");
        Student s2 = new Student(222, "Bob");
        Student s3 = new Student(333, "Cathy");
        Student s4 = new Student(444, "David");

        Dictionary<string, double> gradebook = new Dictionary<string, double>();

        gradebook["Alice"] = 4.0;
        gradebook["Bob"] = 3.6;
        gradebook["Cathy"] = 2.5;
        gradebook["David"] = 1.8;

        if (!gradebook.ContainsKey("Tom"))
        {
            gradebook ["Tom"] = 3.3;
        }

        double total = 0;
        foreach (var gpa in gradebook.Values)
        {
            total += gpa;
        }

        double average = total / gradebook.Count;
        Console.WriteLine("The average GPA is: " + average);

        foreach (Student s in Student.studentList)
        {
            if (gradebook[s.GetName()] > average)
            {
                s.PrintInfo();
            }
        }
    }
}
