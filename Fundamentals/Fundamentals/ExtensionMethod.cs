using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public static class ExtensionMethod
    {
        public static void ExtensionMethodMain()
        {
            var x = new List<int>()
            {
                34,
                2,
                78,
                1
            };

            x.jammer();
            Console.WriteLine(x.jammer());


            var names = new List<string> { "a", "b", "c" };
            Console.WriteLine(names.jammer());
            int a = 5;
            int b = 4;
            Console.WriteLine(a.SquareDifference(b));

            Point first = new Point(1, 2);
            Point second = new Point(3, 4);
            var t = first.manhattandistance(second);
            Console.WriteLine($"Manhattan distance is {t}");



        }

    }


    public static class Extensions
    {
        public static string jammer(this List<int> a)
        {
            return string.Join("", a);
        }

        public static string jammer(this List<string> b)
        {
            return string.Join("", b);
        }

        public static int SquareDifference(this int a, int b)
        {
            return (a * a - b * b);
        }

        public static double manhattandistance(this Point p, Point b)
        {
            return (double)Math.Abs(p.X - b.X) + Math.Abs(p.Y - b.Y);
        }
    }

}
