using System;
using System.Threading.Tasks;

namespace MyPractice
{
    internal class Program
    {
        
        public static async Task Main(string[] args)
        {
            Task task1 = Task.Run(() => {
                int result = asyncExampletsk.Method1();
                Console.WriteLine(result);
            });

            Task task2 = Task.Run(() => {
                Console.WriteLine(asyncExampletsk.Method2());
            });

            Task task3 = Task.Run(() => {
                Console.WriteLine(asyncExampletsk.Method3());
            });

            await Task.WhenAll(task1, task2, task3);
            
        }

    }

}