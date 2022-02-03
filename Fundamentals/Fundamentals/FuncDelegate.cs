using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class FuncDelegate
    {
        public delegate int doubler(int x);

        public void FuncDelegateMain()
        {
            Func<int, int> doubling = x => x * 2;

            printer(doubling);

        }

        public void printer(Func<int, int> func)
        {
            Console.WriteLine("I am here inside the method");
            var f = func(5);
            Console.WriteLine(f);
        }

    }
}
