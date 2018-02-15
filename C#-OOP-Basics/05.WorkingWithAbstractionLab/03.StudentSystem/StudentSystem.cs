using System;
using System.Collections.Generic;

public class StudentSystem
{
    private Dictionary<string, Student> repo;
    public void ParseCommand(string input)
    {
        string[] args = input.Split();

        var command = args[0];
        var name = args[1];
        if (command == "Create")
        {
            CreateCommand(name, args[2], args[3]);
        }
        else if (command == "Show")
        {
            if (repo.ContainsKey(name))
            {
                PrintStudent(name);
            }

        }
    }
    private void PrintStudent(string name)
    {
        var student = repo[name];
        var studentMessage = GetStudentMessage(student);

        Console.WriteLine(studentMessage);
    }

    private static string GetStudentMessage(Student student)
    {
        string studentMessage = $"{student.Name} is {student.Age} years old. ";

        string gradeMessage;
        gradeMessage = GetGradeMessage(student);

        return studentMessage + gradeMessage;
    }

    private static string GetGradeMessage(Student student)
    {
        string gradeMessage;
        if (student.Grade >= 5.00)
        {
            gradeMessage = "Excellent student.";
        }
        else if (student.Grade < 5.00 && student.Grade >= 3.50)
        {
            gradeMessage = "Average student.";
        }
        else
        {
            gradeMessage = "Very nice person.";
        }

        return gradeMessage;
    }

    private void CreateCommand(string name, params string[] ageAndGrade)
    {
        var age = int.Parse(ageAndGrade[0]);
        var grade = double.Parse(ageAndGrade[1]);
        if (!repo.ContainsKey(name))
        {
            repo[name] = new Student();
            var student = new Student(name, age, grade);
            repo[name] = student;
        }
    }
}
