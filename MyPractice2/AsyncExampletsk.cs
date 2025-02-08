using System;
using System.Threading;
namespace MyPractice
{
    public static class asyncExampletsk
    {
        public static int Method1()
        {
            Thread.Sleep(500);
            Console.WriteLine("Method1");
            return 10;
        }
        public static int Method2()
        {
            Console.WriteLine("Method2");
            return 20;
        }
        public static int Method3()
        {
            Console.WriteLine("Method3");
            return 30;
        }
        
    }
}