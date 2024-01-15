namespace AlgoWorld
{

    public interface IAnagramChecker
    {
        public bool CheckAnagram(string spyName, string name);
    }
    public class AnagramChecker : IAnagramChecker
    {
        public bool CheckAnagram(string spyName, string name)
        {
            string newName = "";

            if (spyName.Length != name.Length)
            {
                return false;
            }
            for(int i = 0; i < spyName.Length; i++)
            {
                if (name.Contains(spyName[i]))
                {
                    name.Remove(name.IndexOf(spyName[i]), 1);
                    newName += spyName[i];
                }
            }

            return (newName.Length == spyName.Length)?  true : false;

        }
    }
}