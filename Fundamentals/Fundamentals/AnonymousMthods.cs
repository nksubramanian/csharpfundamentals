using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class AnonymousMethods
    {
        public void AnonymousMethodsMain()
        {
            Func<int, int> function = x => 2 * x;
            decorator(function);
            Func<int, int, int> func = (x, y) => { return x + y; };
            decorator1(func);
            Action printer = () => Console.WriteLine("This is Subbu");
            decorator2(printer);


        }

        public void decorator(Func<int, int> func)
        {
            Console.WriteLine("This is the decorator");
            var y = func(6);
            Console.WriteLine(y);

        }

        public void decorator1(Func<int, int, int> func)
        {
            Console.WriteLine("This is the decorator");
            Console.WriteLine(func(5, 6));
        }

        public void decorator2(Action f)
        {
            f();
        }

    }
}
