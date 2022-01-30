using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class Delegate
    {

        public delegate void printer(string x);

        public static void printwith1(string x)
        {
            Console.WriteLine(x+" one");
        }

        public static void printwithx(string x)
        {
            Console.WriteLine(x + " x");
        }

        public static void printwithy(string x)
        {
            Console.WriteLine(x + " x");
        }


        public delegate bool Filters(string name);

        public static void DelegateMain()
        {
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^");

            List<string> names = new List<string> { "subbu",
                "tom", "david", "amy", "subramanian", "alfred", "jai", "priya", "sneha"};
            Console.WriteLine("less than five "+string.Join(",", namesfilter(names, LessThanFive)));
            Console.WriteLine("more than five "+string.Join(",", namesfilter(names, MoreThanFive)));
            Console.WriteLine("equals five "+string.Join(",", namesfilter(names, EqualsFive)));
            Console.WriteLine("---------------------Using Lambda expression---------------------");
            Console.WriteLine("less than five " + string.Join(",", namesfilter(names, lambda=>(lambda.Length<5))));
            Console.WriteLine("more than five " + string.Join(",", namesfilter(names, lambda => (lambda.Length > 5))));
            Console.WriteLine("equals five " + string.Join(",", namesfilter(names, lambda => (lambda.Length == 5))));

            Console.WriteLine("--------------------Delegate chaining---------------------");

            printer p = printwith1;
            p += printwithx;
            p += printwith1;
            p += printwithy;
            p("subbu");

            p = p - printwith1;


            Console.WriteLine("--------------------Delegate chaining 2---------------------");
            p("subbu");

            var delegates = p.GetInvocationList();

            foreach(var del in delegates)
            {
                Console.WriteLine(del.Method);
            }


            Console.WriteLine("delegate with multiple returns");

            Filters ultimate = LessThanFive;
            ultimate += MoreThanFive;
            ultimate += EqualsFive;


            Console.WriteLine(ultimate("subbu"));

            List<bool> returns = new List<bool>();

            var dels = ultimate.GetInvocationList();

            foreach(var del in dels)
            {
                returns.Add((bool)del.DynamicInvoke("subbu"));
            }

            Console.WriteLine(string.Join(",", returns));

            var answers = ultimate.GetInvocationList().Select(x => x.DynamicInvoke("subbu")).ToList();
            Console.WriteLine(string.Join(",", answers));


        }

        public static bool LessThanFive(string item)
        {
            return item.Length < 5;
        }

        public static bool MoreThanFive(string item)
        {
            return item.Length > 5;
        }

        public static bool EqualsFive(string item)
        {
            return item.Length == 5;
        }



        public static List<string> namesfilter(List<string> input, Filters filter)
        {
            var result = new List<string>();
            foreach(var x in input)
            {
                if(filter(x))
                {
                    result.Add(x);
                }
            }

            return result;

        }

    }
}
