namespace StudentsTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private int facultyNumber;
        private string phone;
        private string email;
        private IList<int> marks;
        private int groupNumber;
        private string groupName;

        public Student(string firstName, string lastName, int age, int facultyNumber, string phone, string email, IList<int> marks, int groupNumber, string groupName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
            this.FacultyNumber = facultyNumber;
            this.GroupName = groupName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be empty");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name cannot be empty");
                }

                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be negative");
                }

                this.age = value;
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Phone cannot be empty");
                }

                this.phone = value;
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Email cannot be empty");
                }

                this.email = value;
            }
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Group Number cannot be negative or equal ot 0");
                }

                this.groupNumber = value;
            }
        }

        public IList<int> Marks
        {
            get
            {
                return this.marks;
            }

            set
            {
                value.ToList().ForEach(
                    x =>
                    {
                        if (x < 2 || x > 6)
                        {
                            throw new ArgumentOutOfRangeException("Marks cannot be smaller than 2 and bigger than 6");
                        }
                    });

                this.marks = value;
            }
        }

        public int FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }

            set
            {
                if ((value < 80000000) || (value > 89999999))
                {
                    throw new ArgumentOutOfRangeException("faculty Number is out of range [80000000..89999999]");
                }

                this.facultyNumber = value;
            }
        }

        public string GroupName
        {
            get
            {
                return this.groupName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Group name cannot be empty");
                }

                this.groupName = value;
            }
        }

        public string MarksToString(IList<int> marksList)
        {
            string result = "[";
            marksList.ToList().ForEach(
                x =>
                {
                    result += x + ", ";
                });

            return result.Trim(' ', ',') + "]";
        }

        public override string ToString()
        {
            string ret = string.Empty;
            this.Marks.ToList().ForEach(
                x =>
                {
                    ret += x + ", ";
                });
            ret = ret.Trim(' ', ',');
            StringBuilder sb = new StringBuilder();
            sb.Append("Name: " + this.FirstName + " " + this.LastName + "\n");
            sb.Append("Age: " + this.Age + "\n");
            sb.Append("Faculty Number: " + this.FacultyNumber + "\n");
            sb.Append("Phone: " + this.Phone + "\n");
            sb.Append("Email: " + this.Email + "\n");
            sb.Append("Marks: " + ret + "\n");
            sb.Append("Group number: " + this.GroupNumber + "\n");
            return sb.ToString();
        }

        public void PrintStudents()
        {
            string marksToString = string.Empty;
            this.Marks.ToList().ForEach(
                x =>
                {
                    marksToString += x + ", ";
                });
            marksToString = marksToString.Trim(' ', ',');
            StringBuilder sb = new StringBuilder();
            sb.Append("Name: " + this.FirstName + " " + this.LastName + "\n");
            sb.Append("Age: " + this.Age + "\n");
            sb.Append("Faculty Number: " + this.FacultyNumber + "\n");
            sb.Append("Phone: " + this.Phone + "\n");
            sb.Append("Email: " + this.Email + "\n");
            sb.Append("Marks: " + marksToString + "\n");
            sb.Append("Group number: " + this.GroupNumber + "\n");
            Console.WriteLine(sb);
        }
    }
}
