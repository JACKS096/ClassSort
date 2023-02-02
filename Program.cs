using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person() { Name = "John", Age = 25 });
            people.Add(new Person() { Name = "Alice", Age = 23 });
            people.Add(new Person() { Name = "Bob", Age = 27 });
            var sortedPeople = people.OrderBy(x => x.Name);
            foreach (var person in sortedPeople)
            {
                Console.WriteLine(person.Name);
            }
            Console.ReadKey();
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
