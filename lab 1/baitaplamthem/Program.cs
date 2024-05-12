using System;
using System.Collections.Generic;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"ten : {Name}, tuoi : {Age}");
    }
}
class Program
{
    static void Main()
    {
        List<Student> studentlist = new List<Student>();

        studentlist.Add(new Student("Alice",20));
        studentlist.Add(new Student("Bob", 22));
        studentlist.Add(new Student("Charlie", 21));  

        foreach (var student in studentlist)
        {
            student .DisplayInfo(); 
        }
    }
}

