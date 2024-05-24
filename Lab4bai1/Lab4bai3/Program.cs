using System;

public class studentLab4
{
    public string Name { get; set; }
    public int Age { get; set; }
    public studentLab4( string name , int age)
    {   
            Name = name;
            Age = age;
    }
}
class Program
{
    static void Main()
    {
        List<studentLab4> students = new List<studentLab4>();
        students.Add(new studentLab4( "VanDat",13 ));
        students.Add(new studentLab4( "VanDung",12 ));
        students.Add(new studentLab4( "QuocKhanh", 15));
        students.Add(new studentLab4( "NgocHau", 20));
        students.Add(new studentLab4("HoangLinh", 16));
        var QuerySyntaxResult = from student in students
                                where student.Age > 12 && student.Age < 20
                                select student;
        Console.WriteLine("sinh vien co tuoi > 12 va tuoi < 20 (Query Syntax) : ");
        foreach (var student in QuerySyntaxResult)
        {
            Console.WriteLine($"Ten : {student.Name} , Tuoi : {student.Age}");
        }

        var MethodSyntaxResult = students.Where(student => student.Age > 12 && student.Age < 20);
        Console.WriteLine("sinh vien co tuoi > 12 va tuoi < 20 (Method Syntax) :");
        foreach(var student in MethodSyntaxResult)
        {
            Console.WriteLine($"Ten : {student.Name} , Tuoi : {student.Age}");
        }
    }
}
