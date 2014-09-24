using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SoftwareUniversity
{
    abstract class  Person
    {
        protected string firstName;
        protected string lastName;
        protected int age;
        protected Regex regex = new Regex("[A-Za-z]+");
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public Person(string firstName,string lastName,int age) : this (firstName,lastName)
        {
            
            this.Age = age;
        }
      
        public int Age
        {
            get { return this.age; }
            protected set
            {
                if (age < 0 || age > 100)
                {
                    throw new ArgumentException("Invalid age", "Person Age");
                }
                this.age = value;
            }
        }
        protected bool checkName(string name)
        {
            Match match = regex.Match(name);
            if (match.Success)
            {
                return true;
            }
            return false;
        }
        public string FirstName
        {
            get { return this.firstName; }
           protected set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Cannot be empty or null", "Person First Name");
                }

                if (!checkName(value))
                {
                    throw new ArgumentException("Invalid input for NAME","Person First Name");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            protected set {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Cannot be empty or null", "Person Last Name");
                }

                if (!checkName(value))
                {
                    throw new ArgumentException("Invalid input for NAME", "Person Last Name");
                }
                this.lastName = value;
            }
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(string.Format("{3} Name: {0} {1}\n{2} years old\n",this.FirstName,this.LastName,this.Age,GetType().Name));
            return str.ToString();
        }
    }
}
