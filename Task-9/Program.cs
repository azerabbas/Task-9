using System;
using System.Collections.Generic;


namespace Task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person[] person = new Person [3]; 


            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter {i+1}. Name : ");

                person[i] = new Person { Name = Console.ReadLine() };
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(person[i].ToString());
            }



           
        }

       


    }

}


