using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class TaskTwo
    {
        public void TaskTwoMain()
        {
            Task task = new Task(() => { 
                printerString("subbu", 200); 
            });
            task.Start();
            Console.WriteLine("In progress");
            task.Wait();
            Console.WriteLine("Completed");

        }

        public void printerString(string name, int d)
        {
            for (int i = 0; i < d; i++)
            {
                Console.WriteLine(name + "_______" + d.ToString());
            }
        }


    }


}
