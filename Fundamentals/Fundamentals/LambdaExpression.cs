using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class LambdaExpression
    {
        //(input) => (work on input);
        //N=>((N%2)==0);
        public static void LambdaExpressionMain()
        {
            Console.WriteLine("*****************Lambda Expression**************");

            List<int> numbers = new List<int>() { 5, 6, 3, 2, 1, 5, 6, 7, 8, 4, 234, 54, 14, 653, 3, 4, 5, 6, 7 };
            var oddNumbers = from number in numbers
                             where number % 2 == 1
                             select number;

            Console.WriteLine(string.Join(",", oddNumbers));


            var oddNumbersSecond = numbers.Where(n=>(n%2==1));
            Console.WriteLine(string.Join(",", oddNumbersSecond));


            object[] mix = { 1, "string", "d", new List<int> { 1, 2, 3 }, new List<int> { 4, 5, 6, 9 }, "dd", "s", "Hello Kitty", 1,2,3,4 };


            var oddNumbersList = numbers.Where(n => (n % 2 == 1)).ToList();
            foreach(var c in oddNumbersList)
            {
                Console.WriteLine(c);

            }

            string[] catNames = { "Lucky", "Bella", "Luna", "Oreo", "Simba", "Toby", "Loki", "Oscar" };
            double avgCatName = catNames.Average(cat => cat.Length);
            double maxCatName = catNames.Max(cat => cat.Length);
            double minCatName = catNames.Min(cat => cat.Length);

            Console.WriteLine($"The average cat name is {avgCatName}, maximum is {maxCatName}, minimum is {minCatName} ");
            
            var allIntegers = mix.OfType<int>();
            Console.WriteLine(string.Join(",", allIntegers));

            var allIntegersList = mix.OfType<int>().ToList();
            foreach(var x in allIntegersList)
            {
                Console.WriteLine(x);
            }



            var allIntegersLessthan4 = mix.OfType<int>().Where(n => (n < 4));
            Console.WriteLine("less than 4 " + string.Join(",", allIntegersLessthan4));




            var integerListavailable = mix.OfType<List<int>>();
            var ListofintegerList = integerListavailable.ToList();

            int temp = 1;
            foreach(var y in ListofintegerList)
            {
                
                Console.WriteLine($"List {temp++} is "+string.Join(",", y));
            }

            var warriors = new List<Warrior>();
            warriors.Add(new Warrior("zfa", 134));
            warriors.Add(new Warrior("zda", 234));
            warriors.Add(new Warrior("zad", 133));
            warriors.Add(new Warrior("qza", 164));
            warriors.Add(new Warrior("ab", 334));
            warriors.Add(new Warrior("aa", 346));
            warriors.Add(new Warrior("aw", 343));
            warriors.Add(new Warrior("ae", 334));
            warriors.Add(new Warrior("al", 343));


            var warriorheight = warriors.Select(s => s.height);
            Console.WriteLine("warrior heights are below");
            Console.WriteLine(string.Join("\n", warriorheight));

            var shortwarriors = warriors.Where(x => (x.height < 300)).Select(x => x.height);
            Console.WriteLine(string.Join("\n", shortwarriors));

            string[] namesLast = { "subbu", "hjkh", "gejkfgku", "dviuewg", "ejf" };
            //namesLast.ForEach(x=>Console.WriteLine(x));
            warriors.ForEach(x => Console.WriteLine(x.height));



        }




    }
}
