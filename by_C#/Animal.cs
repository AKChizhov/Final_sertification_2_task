using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void doCommand() { }

        public Animal(string name, int age) 
        {
            Name = name;
            Age = age;
            Counter counter = new Counter();
            counter.add();
        }
        
    }
}
