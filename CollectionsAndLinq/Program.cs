using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = GenerateListOfPeople();

            Console.WriteLine("What is the age limit you wish to set?: ");
            string ageLimit = Console.ReadLine();
            int ageLimitInt = int.Parse(ageLimit);
            string preferredOccupation = "Dev";

            List<Person> devsAtOrOverAgeLimit = people.Where(x => x.Age >= ageLimitInt && x.Occupation == preferredOccupation).ToList();
            foreach (Person dev in devsAtOrOverAgeLimit)
            {
                Console.WriteLine(dev);
            }

            Console.WriteLine("Type the name of an employee you wish to search for: ");
            string nameSearch = Console.ReadLine();

            List<Person> employeesWithSameFirstNames = people.Where(x => x.FirstName == nameSearch).ToList();
            foreach (Person employee in employeesWithSameFirstNames)
            {
                Console.WriteLine(employee);
            }
        }
        
        public static List<Person> GenerateListOfPeople()
        {
            var people = new List<Person>();

            people.Add(new CollectionsAndLinq.Person { FirstName = "Eric", LastName = "Fleming", Occupation = "Dev", Age = 24 });
            people.Add(new CollectionsAndLinq.Person { FirstName = "Steve", LastName = "Smith", Occupation = "Manager", Age = 34 });
            people.Add(new CollectionsAndLinq.Person { FirstName = "brendan", LastName = "Enrick", Occupation = "Dev", Age = 30 });
            people.Add(new CollectionsAndLinq.Person { FirstName = "Jane", LastName = "Doe", Occupation = "Dev", Age = 35 });
            people.Add(new CollectionsAndLinq.Person { FirstName = "Samantha", LastName = "Jones", Occupation = "Dev", Age = 24 });
            people.Add(new CollectionsAndLinq.Person { FirstName = "Jane", LastName = "Stover", Occupation = "Sales", Age = 32 });

            return people;
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Occupation { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{LastName}, {FirstName}, {Occupation}, {Age}";
        }
    }
}
