using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareUniversity
{
    class SULSTest 
    {
        static void Main(string[] args)
        {
            Trainer aDimitrov = new JuniorTrainer("Atanas", "Dimitrov", 24);
            Trainer vVasilev = new SeniorTrainer("Vladimir", "Vasilev", 25);
            SeniorTrainer sNakov = new SeniorTrainer("Svetlin", "Nakov");
           

            Student vPeshev = new GraduateStudent("Vasil", "Peshev", 21,12345, 4.46);
            Student bDimitrov = new GraduateStudent("Blagoi", "Dimitrov", 34,12346, 5.22);
            Student mIliev= new GraduateStudent("Misho", "Iliev",27, 12347,5.96);

            Student pPeshev = new DropoutStudent("Pesho", "Peshev", 18,12348, 2.33, "low result");
            Student eIvanova = new DropoutStudent("Ekaterina", "Ivanova", 25, 12348, 4.33, "family reasons");

            CurrentStudent sKoleva = new OnlineStudent("Silvia", "Koleva", 22, 12349 ,3.45, "PHP");
            CurrentStudent aKolarov = new OnsiteStudent("Asen", "Kolarov", 22, 12351, 5.85, "Java", 5);

            vVasilev.CreateCourse("PHP");
            sNakov.CreateCourse("Java Basic");
            aDimitrov.CreateCourse("OOP");
            sNakov.PrintCourses();
            sNakov.DeleteCourse("PHP");
            sNakov.PrintCourses();
            List<Person> persons = new List<Person>() { aDimitrov,vVasilev,sNakov,vPeshev, bDimitrov,mIliev,
                pPeshev, eIvanova,sKoleva,aKolarov};
            persons.Where(p => p is CurrentStudent).OrderBy(p => ((Student)p).AverageGrade).ToList().ForEach(p => Console.WriteLine(p.ToString()));
            CurrentStudent.CurrentStudents();
            
        }
    }
}
