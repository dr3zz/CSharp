using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareUniversity
{
    class SeniorTrainer : Trainer
    {
        public SeniorTrainer(string firstName, string lastName, int age = 0)
            : base(firstName, lastName, age)
        {
        }
        public List<string> DeleteCourse(string courseName)
        {
            string deletedCourse = "";
            List<string> tempList = new List<string>();
            foreach (string s in  Trainer.courseList)
            {

                if (!s.ToLower().Equals(courseName.ToLower()))
                {
                    tempList.Add(s);
                }
                else
                {
                    deletedCourse = s;
                }
            }
            Trainer.courseList = tempList;
            Console.WriteLine("Course " +deletedCourse + " has been deleted !");
            return Trainer.courseList;
        }
    }
}
