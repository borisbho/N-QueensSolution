using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_QueensSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Runner runner = new Runner();
            runner.Run();
        }

        class Runner
        {
            public void Run()
            {
                Console.WriteLine("Enter the max amount of queens: ");
                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    RecursiveBackTracker tracker = new RecursiveBackTracker(i);
                    if(tracker.QueenSolutionPossible())
                    {
                        Console.WriteLine(i + ": Solved");
                        Console.WriteLine(tracker.GetBoard());
                        Console.WriteLine(tracker.steps + " Steps\n\n");
                    }
                    else
                    {
                        Console.WriteLine(i + ": Failed\n\n");
                    }
                }
                Console.ReadLine();
            }
        }
    }
}
