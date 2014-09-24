using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareUniversity
{
    abstract class CurrentStudent : Student
    {
        private static int currentStudentNumber = 0;
        protected string currentCurse;

        public CurrentStudent(string firstName,string lastName,int age,int studentNumber,double averageGrade,string currentCurse) : base(firstName,lastName,age,studentNumber,averageGrade)
        {
            this.CurrentCurse = currentCurse;
            CurrentStudent.currentStudentNumber++;
        }
        public static void CurrentStudents()
        {
            Console.WriteLine("Current students: "+CurrentStudent.currentStudentNumber);
        }
        
        public string CurrentCurse
        {
            get
            {
                return this.currentCurse;
            }
            protected set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Cannot be empty or null", "Student : current curse");
                }
                this.currentCurse = value;
            }
        }
    }
}
