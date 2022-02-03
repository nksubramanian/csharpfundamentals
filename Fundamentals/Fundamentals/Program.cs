﻿using System;

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
        }
    }
}
