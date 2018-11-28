using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    string Name;
    int Grade;
    Instructor Teacher;

    public Student(string Name, Instructor Teacher)
    {
        this.Name = Name;
        this.Grade = 0;
        this.Teacher = Teacher;
    }

    public int GetGrade()
    {
        return this.Grade;
    }

    public void SetGrade(int assignedGrade)
    {
        this.Grade = assignedGrade;
        return;
    }

    public void StudentPrint()
    {
        Console.Write(this.Name);
        Console.Write("Collected a grade of ");
        Console.Write(this.Grade);
        Console.Write(" in ");
        Teacher.Print();
        Console.WriteLine("");
        Console.WriteLine("");
        return;
    }

}






