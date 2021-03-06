using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            LINQ.LINQmain();
            LambdaExpression.LambdaExpressionMain();
            Console.WriteLine("***************Extension Method************");
            ExtensionMethod.ExtensionMethodMain();
            Console.WriteLine("***************Generics********************");
            Generics.GenericsMain();
            Delegate.DelegateMain();
            Console.WriteLine("***************************************");
            new DelegateTwo().DelegateTwoMain();
            new FuncDelegate().FuncDelegateMain();
            new ActionDelegate().ActionDelegateMain();
            new AnonymousMethods().AnonymousMethodsMain();
            new AnonymousMethodsTwo().AnonymousMethodsTwoMain();
            Console.WriteLine("********************TASK*******************");
            new TaskLearning().TaskLearningMain();
            Console.WriteLine("********************TASK 2*****************");
            Console.Clear();
            new TaskTwo().TaskTwoMain();
            Console.WriteLine("********************TASK 3*****************");
            Console.Clear();
            new TaskThree().TaskThreeMain();
        }
    }
}
