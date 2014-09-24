using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareUniversity
{
    class DropoutStudent : Student
    {
        private string dropoutReason;

        public DropoutStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, string dropoutReason)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.DropoutReason = dropoutReason;
        }
        public string DropoutReason
        {
            get { return this.dropoutReason; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Cannot be empty or null","Student : dropout");
                }
                this.dropoutReason = value;
            }
        }
        public  void  Reapply()
        {
            StringBuilder reason = new StringBuilder();
            reason.Append("Student name: " + this.FirstName + " " + this.LastName + "\n");
            reason.Append("Age: " + this.Age + "\n");
            reason.Append("Student indefication number:" + this.StudentNumber + "\n");
            reason.Append("Average Grade:" + this.AverageGrade + "\n");
            reason.Append("Dropout Reason: " + this.DropoutReason + "\n");
            Console.WriteLine(reason.ToString()); 
        }
    }
}
