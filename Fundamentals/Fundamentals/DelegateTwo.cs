using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class DelegateTwo
    {
        public delegate bool func(string message);

        public void DelegateTwoMain()
        {
            string name = "subbu";

            func x = lessthanfive;
            x += greaterthanfive;
            x += equalsfive;

            var list = new List<bool>();
            var temp = x.GetInvocationList();
            foreach(var e in temp)
            {
                list.Add((bool)e.DynamicInvoke(name));

            }


            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine(string.Join(",", list));
            //var ty = delegatereturn<string>(name);
            //Console.WriteLine(string.Join(",", ty));

        }


       /* public static List<T> CatchAllResults<T>(Delegate del, object parameter = null)
        {
            List<T> result = del.GetInvocationList()
                                .Select(d => (T)d.DynamicInvoke(parameter))
                                .ToList();
            return result;
        }

        public static void check(Delegate del)
        {
            del("subbu");
        }*/


        private bool lessthanfive(string name)
        {
            return name.Length < 5;
        }

        public bool greaterthanfive(string name)
        {
            return name.Length > 5;
        }

        public bool equalsfive(string name)
        {
            return name.Length == 5;
        }

    }
}
