using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class TaskLearning
    {
        public void TaskLearningMain()
        {
            Console.Clear();
            Task task = new Task(printer);
            task.Start();
            Console.WriteLine("In Progress");
            task.Wait();
            Console.WriteLine("Finished");
            Console.WriteLine("**************************Starting new********************");
            Task t = Task.Factory.StartNew(printer);
            Console.WriteLine("In progress");
            t.Wait();
            Console.WriteLine("-------------Finished----------");
            task = Task.Run(new Action(printer));
            Console.WriteLine("In Progress");
            task.Wait();
            Console.WriteLine("Finished");

           
        }


        public void printer()
        {
            int u = 0;
            for(int i = 0; i<2000;i++)
            {
                Console.WriteLine(u++);
            }
        }

    }
}
