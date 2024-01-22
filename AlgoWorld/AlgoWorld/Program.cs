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
            bool uniqueName = uniqueNameChecker.CheckForNameDuplication();
            /* Second algorithm to run
             * There are spies hiding throughout all of AlgoWorld! The spies aren't too sneaky though,
             * with their true identities being easy to work out becuase they always use anagrams of their
             * real names as an alias eg Bobby would become the spy Ybbob
             * Given a spy name and a true identity, create an algorithm that can identify whether the spy 
             * and the true identity are one and the same by seeing if the spy name and the true identity names are
             * angrams of eachother
             */
            AnagramChecker anagramChecker = new AnagramChecker();
            bool isAnagram = anagramChecker.CheckAnagram("LordHood", "HoodLord");
            /* Third algorithm to run
             * In Algo World, to defeat the first DragonLord, the fabled Red Dragon, you must find
             * find two heroes whose combined levels equal a certain value. The only problem is you have been given 
             * a list of heroes by the king and do not know the value the combined levels need to hit ahead of time.
             * However, you do know that two of the heroe's levels will add up to the value. You need to create an 
             * algorithm to return the index of the two heroes in the list.
             */
            UnperformantHeroLevelFinder badHeroFinder = new UnperformantHeroLevelFinder();
            badHeroFinder.FindHeroIndexes(new int[] { 1, 2 }, 3);
            PerformantHeroLevelFinder goodHeroFinder = new PerformantHeroLevelFinder();
            goodHeroFinder.FindHeroIndexes(new int[] { 1, 2 }, 3);
        }
    }
}