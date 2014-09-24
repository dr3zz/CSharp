using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareUniversity
{
    abstract class Student : Person
    {
        private static int numberOfStudent = 0;
        protected int studentNumber;
        protected double averageGrade;

        public Student(string firstName, string lastName, int age, int studentNumber, double averageGrade)
            : base(firstName, lastName, age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
            Student.numberOfStudent++;

        }
        public static void NumberOfStudents()
        {
            Console.WriteLine(Student.numberOfStudent);
        }
        public double AverageGrade
        {
            get
            { return this.averageGrade; }
           protected set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentException("Average grade can be only in rage 2 and 6","Student : Average Grade");
                }
                this.averageGrade = value;
            }
        }
        public int StudentNumber
        {
            get { return this.studentNumber; }
            protected set
            {
                if (value < 10000 || value > 99999)
                {
                    throw new ArgumentException("Invalid student number must be 5 digits", "Student : Student Number");
                }
                this.studentNumber = value;
            }
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString());
            return str.Append(string.Format("Student number: {0}\nAverage grade: {1}\n", this.StudentNumber, this.AverageGrade)).ToString();
        }
    }
}
