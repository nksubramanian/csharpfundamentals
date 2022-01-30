using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class Generics
    {
        public static void GenericsMain()
        {
            var a = comparex(3, 3);
            var b = comparex('c', 'c');
            var c = comparex("subbu", "subbu");
            Console.WriteLine(a + "   " + b + "   " + c);

            var a1 = compare(3, 3);
            var b1 = compare('c', 'c');
            var c1 = compare("subbu", "subbu");
            Console.WriteLine(a1 + "   " + b1 + "   " + c1);


            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            int[] a11 = { 1, 2, 0, 0 };
            int[] b11 = { 0, 0, 1, 2 };
            var f = listincrementer(a11, b11);
            Console.WriteLine(string.Join(",", f));

            var bio1 = new Bio(24);
            var bio2 = new Bio(36);
            Console.WriteLine("bio1>bio2 " + compare(bio1, bio2));

            var first = new MyList<int>();
            first.Add(1);
            first.Add(2);
            first.Add(3);

            Console.WriteLine("999999999999999999999999999999999999999999");

            Console.WriteLine(first.list[0]);
            Console.WriteLine(first.list[1]);
            Console.WriteLine(first.list[2]);


            first[2] = 45;

            Console.WriteLine("altered values of list are below");
            Console.WriteLine(first[0]);
            Console.WriteLine(first[1]);
            Console.WriteLine(first[2]);

            var second = new MyList<int>();
            second.Add(1);
            second.Add(2);
            second.Add(3);

            var third = new MyList<int>();
            third = first + second;

            Console.WriteLine("*******************Third is below");

            Console.WriteLine(third.ToString());





        }

        public static bool comparex(object a, object b)
        {
            return (a == b);

        }

        public static bool compare<T>(T a, T b) where T:IComparable<T>
        {
            return a.CompareTo(b)==0;
        }

        public static T[] listincrementer<T>(T[] a, T[] b) where T:IComparable<T>
        {
            for(int i = 0; i<a.Count();i++)
            {
                if (a[i].CompareTo(b[i])<0)
                    a[i] = b[i];
                
            }

            return a;
        }



    }
}
