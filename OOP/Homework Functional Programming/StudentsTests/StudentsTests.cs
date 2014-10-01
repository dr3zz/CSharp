namespace StudentsTests
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Threading.Tasks;

    public static class StudentsTests
    {
        private static void Main(string[] args)
        {
            Console.BufferHeight = 1000;
            Student maria = new Student(
                "Maria", 
                "Grigorova", 
                19, 
                80001401, 
                "+35952 ", 
                "mariika@abv.bg", 
                new List<int>() { 4, 6, 5 }, 
                2, 
                "PHP");
            Student petur = new Student(
                "Peter", 
                "Petrov", 
                24, 
                80001402, 
                "+3592 ", 
                "pesho@gmail.com", 
                new List<int>() { 5, 6, 6, 6 }, 
                2, 
                "JavaScript");
            Student georgi = new Student(
                "Georgi", 
                "Simeonov", 
                18, 
                80001403, 
                "+3592 ", 
                "email@", 
                new List<int>() { 3, 4, 4, 5 }, 
                2, 
                "OOP");
            Student todor = new Student(
                "Todor", 
                "Todorov", 
                21, 
                80001404, 
                "02 613 31 33", 
                "email@", 
                new List<int>() { 5, 6, 4, 5 }, 
                1, 
                "OOP");
            Student vasil = new Student(
                "Vasil", 
                "Vasilev", 
                27, 
                80001512, 
                "+359 2 945 23 45 ", 
                "email@abv.bg", 
                new List<int>() { 2, 6, 2, 5 }, 
                1, 
                "PHP");
            Student weekStudent1 = new Student(
                "Atanas", 
                "Dobrev", 
                27, 
                80001543, 
                "+359 2 943 52 45 ", 
                "naseto@abv.bg", 
                new List<int>() { 2, 6, 2, 5 }, 
                1, 
                "OOP");
            List<Student> students = new List<Student>() { maria, petur, georgi, vasil, todor, weekStudent1 };

            //// Problem 4.Students by Group
            var sortByGroupNumber = students.OrderBy(name => name.FirstName).Where(number => number.GroupNumber == 2);
            Console.WriteLine("Students by Group");
            Console.WriteLine("----------------------------\n");
            foreach (var item in sortByGroupNumber)
            {
                item.PrintStudents();
            }

            //// Problem 5.Students by First and Last Name
            Console.WriteLine("Students by First and Last Name");
            Console.WriteLine("----------------------------\n");
            var sortByName =
                students.OrderBy(name => name.FirstName).Where(name => name.FirstName.CompareTo(name.LastName) < 0);
            foreach (var item in sortByName)
            {
                item.PrintStudents();
            }

            //// Problem 6.Students by Age
            Console.WriteLine("Student by Age");
            Console.WriteLine("----------------------------\n");
            var sortByAge =
                students.OrderBy(name => name.FirstName)
                    .Where(age => ((age.Age >= 18) && (age.Age <= 24)))
                    .Select(x => new { x.FirstName, x.LastName, x.Age });
            foreach (var item in sortByAge)
            {
                Console.WriteLine(item);
            }

            //// Problem 7.Sort Students
            Console.WriteLine("Sort Students");
            Console.WriteLine("----------------------------\n");
            var sortStudents = students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);
            var sortStudentsLinq = from student in students
                                   orderby student.FirstName descending, student.LastName descending
                                   select student;
            Console.WriteLine("Sorted student by Descending\n");
            foreach (var item in sortStudents)
            {
                item.PrintStudents();
            }

            Console.WriteLine("Sorted student by Descending with LINQ Query\n");
            foreach (var student in sortStudentsLinq)
            {
                student.PrintStudents();
            }

            ////Problem 8.Filter Students by Email Domain
            var studentEmail = students.Where(x => x.Email.Contains("@abv.bg"));
            Console.WriteLine("Filter student by email");
            Console.WriteLine("----------------------------\n");
            foreach (var student in studentEmail)
            {
                student.PrintStudents();
            }

            ////Problem 9.Filter Students by Phone
            var studentPhone =
                students.Where(
                    x => x.Phone.StartsWith("02") || x.Phone.StartsWith("+3592") || x.Phone.StartsWith("+359 2"));
            Console.WriteLine("Filder student phone number");
            Console.WriteLine("----------------------------\n");
            foreach (var student in studentPhone)
            {
                student.PrintStudents();
            }

            //// Problem 10.Excellent Students
            var excellentStudent =
                students.Where(x => x.Marks.Any(y => y.Equals(6)))
                    .Select(x => new { FullName = x.FirstName + " " + x.LastName, Marks = x.MarksToString(x.Marks) });
            Console.WriteLine("Excellent Students");
            Console.WriteLine("----------------------------\n");
            foreach (var student in excellentStudent)
            {
                Console.WriteLine(student);
            }

            ////Problem 11.Weak Students
            Console.WriteLine("Week Students");
            Console.WriteLine("----------------------------\n");
            var weekStudents = students.Where(x => x.Marks.Count(m => m == 2) == 2);
            foreach (var weekStudent in weekStudents)
            {
                weekStudent.PrintStudents();
            }

            //// Problem 12.Students Enrolled in 2014
            var studentByFacultyNumber =
                students.Where(x => x.FacultyNumber.ToString().Substring(0, 6).EndsWith("14"))
                    .Select(y => new { Marks = y.MarksToString(y.Marks) });
            Console.WriteLine("\nStudent enrolled in 2014");
            Console.WriteLine("----------------------------\n");
            foreach (var item in studentByFacultyNumber)
            {
                Console.WriteLine(item);
            }

            ////Problem 13. Students by Groups
            var groupByGroupName = students.GroupBy(
                g => g.GroupName, 
                (key, s) => new { GroupName = key, students = s.ToList() });
            foreach (var item in groupByGroupName)
            {
                Console.WriteLine(item.GroupName);
                Console.WriteLine("----------------------------");
                Console.WriteLine(string.Join("\n", item.students));
                Console.WriteLine();
            }
           ////Problem 15. Students Joined to Specialties
            List<StudentSpecialty> specialties = new List<StudentSpecialty>()
                                                     {
                                                         new StudentSpecialty(
                                                             "Web Developer", 
                                                             80001401), 
                                                         new StudentSpecialty(
                                                             "Web Developer", 
                                                             80001402), 
                                                         new StudentSpecialty(
                                                             "QA Engineer", 
                                                             80001402),
                                                         new StudentSpecialty(
                                                             "PHP Developer", 
                                                             80001403), 
                                                         new StudentSpecialty(
                                                             "PHP Developer", 
                                                             80001404), 
                                                         new StudentSpecialty(
                                                             "QA Engineer", 
                                                             80001404)
                                                     };
            var studentSpecialty = from st in students
                                   join sp in specialties on st.FacultyNumber equals sp.FacNum
                                   orderby st.FirstName
                                   select
                                       new
                                           {
                                               Name = st.FirstName + " " + st.LastName, 
                                               FacNum = sp.FacNum, 
                                               Specialty = sp.SpecialtyName
                                           };
            Console.WriteLine("Students Joined to Specialties");
            Console.WriteLine("----------------------------\n");
            foreach (var student in studentSpecialty)
            {
                Console.WriteLine(student);
            }
        }
    }
}