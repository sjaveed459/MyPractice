// See https://aka.ms/new-console-template for more information
using System;
using System.Threading.Tasks;
using MyPractice1;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //AsynExample asynExample = new AsynExample();

        Console.WriteLine(AsynExample.Method1());

        Console.WriteLine(AsynExample.Method2());

        Console.WriteLine(AsynExample.Method3());
             
    }

    

}