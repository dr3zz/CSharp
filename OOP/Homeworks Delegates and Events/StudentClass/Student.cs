namespace StudentClass
{
    using System;
    using System.ComponentModel;

    public class Student
    {
        private string name;

        private int age;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public event EventHandler<PropertyChangedEventArgs<string>> ProperyChanged;
      
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Student Name cannot be empty or null");
                }

                this.OnPropertyChanged(new PropertyChangedEventArgs<string>("Name:", this.name, value));
                this.name = value;
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
                    throw new ArgumentException("Age cannot be negative");
                }

                this.OnPropertyChanged(
                    new PropertyChangedEventArgs<string>("Age", this.Age.ToString(), value.ToString()));
                this.age = value;
            }
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs<string> e)
        {
            if (this.ProperyChanged != null)
            {
                this.ProperyChanged(this, e);
            }
        }
    }
}