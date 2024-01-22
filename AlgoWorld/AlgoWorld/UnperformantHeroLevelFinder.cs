namespace AlgoWorld
{
    interface IHeroLevelFinder {
        public int[] FindHeroIndexes(int[] heroLevels, int levelToReach);
    }

    public class UnperformantHeroLevelFinder : IHeroLevelFinder
    {
        public UnperformantHeroLevelFinder()
        {
        }

        public int[] FindHeroIndexes(int[] heroLevels, int levelToReach)
        {
            for(int i = 0; i < heroLevels.Length; i++)
            {
                for(int j = 0; j < heroLevels.Length; j++)
                {
                    if(i != j)
                    {
                        if ((heroLevels[i] + heroLevels[j]) == levelToReach){
                            return new int[] { i, j };
                        }
                    }
                }
            }
            return new int[] { -1, -1 };
        }
    }
}