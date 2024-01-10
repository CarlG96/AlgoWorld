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
            UniqueNameChecker uniqueNameChecker = new UniqueNameChecker();
            uniqueNameChecker.Run();
            /* Second algorithm to run
             * There are spies hiding throughout all of AlgoWorld! The spies aren't too sneaky though,
             * with their true identities being easy to work out becuase they always use anagrams of their
             * real names as an alias eg Bobby would become the spy Ybbob
             * Given a spy name and a true identity, create an algorithm that can identify whether the spy 
             * and the true identity are one and the same by seeing if the spy name and the true identity names are
             * angrams of eachother
             */
            AnagramChecker anagramChecker() = new anagramChecker();
            anagramChecker().Run();
        }
    }
}