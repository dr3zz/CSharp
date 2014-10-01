namespace StudentClass
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Student student = new Student("Peter", 15);
            student.ProperyChanged +=
                (sender, eventArgs) =>
                    {
                        Console.WriteLine(
                            "Property changed: {0} (from {1} to {2})",
                            eventArgs.PropertyName,
                            eventArgs.OldValue,
                            eventArgs.NewValue);
                    };
            student.Name = "Maria";
            student.Age = 16;
        }
    }
}