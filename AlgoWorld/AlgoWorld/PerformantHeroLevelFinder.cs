namespace AlgoWorld
{
    public class PerformantHeroLevelFinder : IHeroLevelFinder

    {
        public PerformantHeroLevelFinder()
        {
        }

        public int[] FindHeroIndexes(int[] heroLevels, int levelToReach)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for(int i = 0; i < heroLevels.Length; i++)
            {
                int x = levelToReach - heroLevels[i];

                if (map.ContainsKey(x))
                {
                    return new int[] { map[x], i };
                }
                if (!map.ContainsKey(heroLevels[i]))
                {
                    map[heroLevels[i]] = i;
                }

                
            }
            return new int[] { -1, -1 };
        }
    }
}