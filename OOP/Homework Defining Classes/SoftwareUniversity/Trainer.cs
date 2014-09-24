using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareUniversity
{
    abstract class Trainer : Person
    {
        protected static List<string> courseList = new List<string>();

        public Trainer(string firstName, string lastName, int age = 0)
            : base(firstName, lastName, age)
        {

        }

        public void CreateCourse(string createCourse)
        {
            foreach (string s in Trainer.courseList)
            {
                if (s.ToLower().Equals(createCourse.ToLower()))
                {
                    Console.WriteLine("This course already exists");
                    return;
                }

            }
            Trainer.courseList.Add(createCourse);
            Console.WriteLine("New course " + createCourse + " has been created");


        }
        public void PrintCourses()
        {
            Console.Write("Current Courses: [");
            for (int i = 0; i < Trainer.courseList.Count; i++)
            {
                if (i < Trainer.courseList.Count - 1)
                {
                    Console.Write(Trainer.courseList[i] + ", ");
                }
                else
                {
                    Console.Write(Trainer.courseList[i]);
                }
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }
}
