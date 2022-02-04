using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class AnonymousMethodsTwo
    {
        public void AnonymousMethodsTwoMain()
        {
            string[] names = { "subbu", "tom", "tohja", "yohan", "sam", "ary", "subramanian" };

            Func<string, bool> lessthaFive = x => x.Length < 5;

            Func<string[], Func<string, bool>,List<string>> func = (array,filter) => {

                List<string> results = new List<string>();
                foreach(var x in array)
                {
                    if (filter(x))
                        results.Add(x);
                }
                return results;

            };

            List<string> v = func(names, lessthaFive);

            foreach(var t in v)
            {
                Console.WriteLine(t);
            }

        }

    }
}
