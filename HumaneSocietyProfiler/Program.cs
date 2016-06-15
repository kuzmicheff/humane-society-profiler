using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyProfiler
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Age = 5; // set { }
            Console.WriteLine(animal.Age); // get { }
        }
    }
}
