using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class MyList<T>
    {
        public T[] list;
        public int count;
        public int capacity;


        public MyList()
        {
            list = new T[2];
            count = 0;
            capacity = 2; 
        }

        public T this[int index]
        {
            get
            {
                return this.list[index];

            }
            set
            {
                this.list[index] = value;
            }
        }


        public static MyList<T> operator +(MyList<T> first, MyList<T> second)
        {
            MyList<T> third = new MyList<T>();
            for(int i = 0; i<first.count;i++)
            {
                third.Add((dynamic)first[i] + (dynamic)second[i]);
            }
            return third;

        }

        public void Add(T a)
        {
            if(count == capacity)
            {
                T[] newone = new T[2 * count];
                capacity = 2 * count;
                for(int i = 0;i<count;++i)
                {
                    newone[i] = list[i];

                }

                list = newone;

            }
            
            list[count++] = a;

        }



        public override string ToString()
        {
            return string.Join(",", list);
        }

    }
}
