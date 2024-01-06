using System.Runtime.ExceptionServices;

namespace AlgoWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AlgoWorld!");
            /* First algorithm to run
             * Given an array of characters in AlgoWorld, return true if any character name
             * appears twice in the array, and return false if every character name in the array is distinct */
            FirstAlgorithmRunner firstAlgorithmRunner = new FirstAlgorithmRunner();
            firstAlgorithmRunner.Run();
        }
    }
}