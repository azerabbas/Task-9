using System;

namespace Task_9._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter {i+1}. name");
                persons[i] = new Person(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }
            
        }
    }
}
