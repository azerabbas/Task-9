using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9._3
{
    public class Teacher: Person
    {
        public void Explain(string exp)
        {
            Console.WriteLine($"I'm explaining : {exp}");
        }
    }
}
