using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class TaskThree
    {
        public void TaskThreeMain()
        {
            Task<string> task = new Task<string>(() => getString("subbu", 20));
            task.Start();
            Console.WriteLine("In Progress");
            task.Wait();
            Console.WriteLine(task.Result);
            Console.WriteLine("Finised!!!!!");


        }

        public string getString(string name, int g)
        {
            string h = "";
            for(int i = 0; i<g;i++)
            {
                h += name;
            }

            return h;
        }

    }
}
