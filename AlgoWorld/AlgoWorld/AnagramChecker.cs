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
            return true;
        }
    }
}