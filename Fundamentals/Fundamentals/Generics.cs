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
