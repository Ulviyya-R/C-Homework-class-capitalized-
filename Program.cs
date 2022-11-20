using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student1 student = new Student1("Ulviyya", "Rustamova", "P230", 70, false);
            Console.WriteLine(student.Name);

            student.Graduated();
            student.Points();

        }
    }
}
