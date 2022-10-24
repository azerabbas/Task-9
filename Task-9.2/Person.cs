using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9._2
{
    public class Person
    {
        public string Name { get; set; }

        public Person (string name)
        {
            Name=name;
        }
        public override string ToString()
        {
            return $"My name is : {Name} ";
        }
    }
}
