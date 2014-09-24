using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class Person
    {
        private string name;
        private string email;
        private int age;
        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Email = email;
            this.Age = age;

        }
        public Person(string name, int age)
            : this(name, age, null)
        {
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty","Name");
                }
                this.name = value;
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if((value !=null) && ( !value.Contains("@")))
                {
                    throw new ArgumentException ("Invalid input" ,"Email");
                }
                this.email = value;
            }
        }
        public int Age
        { get 
        {
            return this.age;
        }
            set
            {
                if ((value < 1) || ( value > 100)) {
                    throw new ArgumentException("Outside the allowed range![1..100] ", "Age");
                }
                this.age = value;
            }
        }
        public override string ToString()
        {
            return string.Format("name: {0}, age: {1}",this.Name,this.Age) + (this.Email == null ?"" : ", email: " + this.Email);
        }
        
    }
   
}
