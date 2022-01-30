using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class LINQ
    {
        public static void LINQmain()
        {
            string sentence = "I love cats";
            string[] catNames = { "Lucky", "Bella", "Luna", "Oreo", "Simba", "Toby", "Loki", "Oscar" };
            int[] numbers = { 5, 6, 3, 2, 1, 5, 6, 7, 8, 4, 234, 54, 14, 653, 3, 4, 5, 6, 7 };

            var getTheNumbers = from number in numbers
                                where (number < 5)
                                select number;
            Console.WriteLine(string.Join(",", getTheNumbers));

            var catsWithA = from cat in catNames
                            where cat.Contains("a") && (cat.Length<5)
                            select cat;

            Console.WriteLine(string.Join(",", catsWithA));

            var getTheNumbersCondition = from number in numbers
                                         where number > 5
                                         where number < 10
                                         select number;

            Console.WriteLine(string.Join(",", getTheNumbersCondition));

            var orderNumbers = from number in numbers
                               where number > 5
                               orderby number descending
                               select number;

            Console.WriteLine(string.Join(",", orderNumbers));

            Console.WriteLine("_______________________________________________________");

            var Persons = new List<Person>();
            Persons.Add(new Person("as1", 23, 45));
            Persons.Add(new Person("as2", 233, 45));
            Persons.Add(new Person("as3", 223, 45));
            Persons.Add(new Person("as4", 236, 415));
            Persons.Add(new Person("as5", 237, 452));
            Persons.Add(new Person("as6", 243, 453));
            Persons.Add(new Person("as7", 235, 453));
            Persons.Add(new Person("as8", 236, 435));
            Persons.Add(new Person("as8", 238, 456));
            Persons.Add(new Person("as9", 238, 455));


            var LinqonClass = from person in Persons
                              where person.weight > 100
                              orderby person.weight descending, person.height ascending
                              select person;


            foreach(var x in LinqonClass)
            {
                Console.WriteLine($"name is {x.name} && height is {x.height} && weight is {x.weight}");
            }

            var LinqClassQuery = from person in Persons
                                 where person.weight > 100
                                 select person.name;

            foreach(var x in LinqClassQuery)
            {
                Console.WriteLine(x);
            }

            string Numbersentence = "1 2 3 4 5";

            //var x = Numbersentence.Split(" ").ForEach(gg => Int.Parse(gg)).ToArray();








        }


    }
}
