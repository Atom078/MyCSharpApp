using System;

namespace PracticalWork1
{
    class Student
    {
        public string Name;
        public string Group;
        public double AverageScore;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Student student1 = new Student();
            student1.Name = "Іван Петренко";
            student1.Group = "КН-21";
            student1.AverageScore = 88.5;

            Student student2 = new Student();
            student2.Name = "Марія Коваленко";
            student2.Group = "КН-22";
            student2.AverageScore = 94.2;

            Console.WriteLine($"Ім'я: {student1.Name}");
            Console.WriteLine($"Група: {student1.Group}");
            Console.WriteLine($"Середній бал: {student1.AverageScore}");
            Console.WriteLine();
            Console.WriteLine($"Ім'я: {student2.Name}");
            Console.WriteLine($"Група: {student2.Group}");
            Console.WriteLine($"Середній бал: {student2.AverageScore}");

            Console.ReadKey();
        }
    }
}