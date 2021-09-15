using System;

namespace ProgrammingProblem
{
    class Program
    {
        static void Main()
        {
            Console.Write("Press any key to begin the programming problem...");
            Console.ReadKey(true);
            Console.WriteLine();

            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FooBar");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Foo");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Bar");
                }
                else
                {
                    Console.WriteLine(i.ToString());
                }
            }

            Console.Write("Press any key to exit...");
            Console.ReadKey(true);
            Environment.Exit(0);
        }
    }
}