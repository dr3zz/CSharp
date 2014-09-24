using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareUniversity
{
    class OnsiteStudent : CurrentStudent
    {
        private int numberOfVisits;

        public OnsiteStudent(string firstName,string lastName,int age,int studentNumber,double averageGrade,string currentCurse,int visits) :base(firstName,lastName,age,studentNumber,averageGrade,currentCurse)
        {
            this.NumberOfVisists = visits;
        }
        public int NumberOfVisists
        {
            get { return this.numberOfVisits; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cannot be negative", "Current Student - visits");
                }
                this.numberOfVisits = value;
            }
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString());
            return str.Append(string.Format("Current Course: {0}\nNumber of visits {1}\n", this.CurrentCurse,this.NumberOfVisists)).ToString();
        }
    }
}
