using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class Bio:IComparable<Bio>
    {
        public int age;

        public Bio(int age)
        {
            this.age = age;
        }

        public int CompareTo(Bio other)
        {
            if (this.age < other.age)
                return 1;
            if (this.age == other.age)
                return 0;
            return -1;

        }
    }
}
