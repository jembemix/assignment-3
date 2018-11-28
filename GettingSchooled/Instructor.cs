using System;

public class Instructor
{
    string Name;
    string CourseName;
    //get and set for name and course name

    public Instructor(string Name, string CourseName)
    {
        this.Name = Name;
        this.CourseName = CourseName;
}

    //method for SetStudentGrade with parameters

    //method to print names and such


    public void SetStudentGrade(Student student, int Grade)
    {
        student.SetGrade(Grade);

    }
    public void Print()
    {
        System.Console.WriteLine(this.CourseName);
        System.Console.Write(" which is taught by Professor ");
        System.Console.Write(this.Name);
        System.Console.Write(".");
    }
}


    