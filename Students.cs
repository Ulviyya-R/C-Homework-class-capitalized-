using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Student1
    {
        public string Name;
        public string Surname;
        public string Group;
        public int Point;
        public bool IsGraduated;

        public Student1(string name, string surname, string group, int point, bool isgraduated)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            IsGraduated = isgraduated;

        }

        public void Graduated()
        {
            if (IsGraduated)
            {
                Console.WriteLine("This student has already graduated");
            }
            else
                Console.WriteLine("This student will continue his studies");
        }


        public void Points()
        {
            if (Point > 80)
            {
                Console.WriteLine(" You are registered for the next exam ");
            }
            else
            {
                Console.WriteLine(" Sorry that you are not admitted to the next exam ");
            }
        }

    }
}

