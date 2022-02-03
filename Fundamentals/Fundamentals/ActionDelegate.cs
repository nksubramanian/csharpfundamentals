using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class ActionDelegate
    {
        public void ActionDelegateMain()
        {
            Action<int, int> func = summation;
            decorator(func);



        }


        public void summation(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        public void decorator(Action<int, int> y)
        {
            Console.WriteLine("I am inside decorator");
            y(5,6);
        }
            


    }
}
