using System;

namespace MyConsoleAppNamespace
{
    public class Test
    {
        private int numb;

        // Constructor
        public Test()
        {
            numb = 0;
        }

        // Method to increase the number and print it
        public void IncreaseNumber()
        {
            Console.WriteLine(numb);
            numb += 1;
        }
    }

    public static class Program
    {
        public static void Main()
        {
            Test test = new Test();

            // Calling the IncreaseNumber method multiple times
            test.IncreaseNumber(); // Output: 0
            test.IncreaseNumber(); // Output: 1
            test.IncreaseNumber(); // Output: 2
        }
    }
}