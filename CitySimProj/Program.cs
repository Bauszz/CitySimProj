using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitySimProj
{
    internal class Program
    {
        new List<Person> People = new List<Person>();

        static void Main(string[] args)
        {
            People.Add(Addperson("Anna", 12, false, Race.White));
            Console.WriteLine(People[0]);
        }
    }
}
