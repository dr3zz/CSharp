using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareUniversity
{
    class OnlineStudent : CurrentStudent
    {
        public OnlineStudent(string firstName,string lastName,int age,int studentNumber,double averageGrade, string currentCurse)
            : base(firstName,lastName,age,studentNumber,averageGrade,currentCurse)
        {

        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(base.ToString());
            return str.Append(string.Format("Current Course: {0}\n", this.CurrentCurse)).ToString();
        }
    }
     
}
