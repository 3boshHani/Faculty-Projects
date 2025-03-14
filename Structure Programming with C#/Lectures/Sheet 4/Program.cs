using System;
class Program 
{
    // عبدالرحمن هاني محمود علي = فيزيا و حاسب = اقل من 68
    public struct Student 
    {
        public int id;
        public string name;
        public Degrees degrees;
    }
    public struct Degrees
    {
        public int midTerm;
        public int semesterWork;
        public int final;
    }
    public static void Main()
    {
        // Degrees object should be initalized first due to compiler
        Degrees d1 = new Degrees {midTerm = 60 , semesterWork = 60 , final = 180};
        Student s1 = new Student {id = 1, name = "Ahmed", degrees = d1};
        //
        Console.WriteLine($"Student ID: {s1.id}");
        Console.WriteLine($"Student Name: {s1.name}");
        Console.WriteLine($"MidTerm: {s1.degrees.midTerm}");
        Console.WriteLine($"Semester Work: {s1.degrees.semesterWork}");
        Console.WriteLine($"Final: {s1.degrees.final}");
    }
}