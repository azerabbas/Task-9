using System;

namespace Task_9._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person persons = new();
            persons.Greet();

            Student student = new();
            student.ShowAge(30);

            Teacher teacher = new();
            teacher.Greet();
            teacher.ShowAge(35);
            teacher.Explain("Men bir eded muellimem :)");

        }
        
    }
}
