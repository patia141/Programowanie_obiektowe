using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab4.Zad2
{
    class Nauczyciel: Student
    {
        public string Title { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();

        public override string GetFullName()
        {
            return $"{Title} {base.GetFullName()}";
        }

        public void WhichStudentCanGoHomeAlone()
        {
            foreach(var student in Students.Where(x => x.CanGoHomeAlone()))
            {
                Console.WriteLine(student.GetFullName());
            }
        }

        public void DisplayClass(DateTime date)
        {
            Console.WriteLine($"{GetEducationInfo()} Day {date.DayOfWeek}");
            Console.WriteLine($"Nauczyciel {GetFullName()}");
            Console.WriteLine(GetEducationInfo());
            var i = 0;
            foreach(var student in Students)
            {
                i++;
                //Console.WriteLine($"{i}. {student.GetFullName()")
            }
        }
    }
}
