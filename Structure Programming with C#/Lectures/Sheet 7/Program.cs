using System;
using System.IO;
class Program 
{
    public static void Main()
    {
        string input = "names.txt";
        string output = "sortedNames.txt";

        string[] names = File.ReadAllLines(input);
        
        Array.Sort(names);
        
        File.WriteAllLines(output, names);

        Console.WriteLine("Done");
        // عبدالرحمن هاني محمود علي = فيزياء و حاسب = اقل من 68
    }

    public static void Greeting() {
        // when calling method 
        return Console.WriteLine("Hello C#");
    }

        public static string Greeting() {
        // when calling method 
        return "Hello C#"
    }

    struct School
    {
        public int teachers;
        public int students;
    }

    School firstSchool = new School();
    firstSchool.teachers = 12;
    firstSchool.students = 50;

    School secondSchool = new School();
    secondSchool.teachers = 15;
    secondSchool.students = 100;
    
    int [,] matrix = {{1, 2, 3,}, {4, 5, 6,}, {7, 8, 9}}
    
    string name = "Welcome";
}