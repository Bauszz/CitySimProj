using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitySimProj
{
    internal class Program
    {
        static List<Person> People = new List<Person>();

        static void Main(string[] args)
        {
            Person p1 = new Person("Marcccel", 18, true, Race.White);
            People.Add(p1);
            Console.WriteLine(People[0]);
        }
    }
}
