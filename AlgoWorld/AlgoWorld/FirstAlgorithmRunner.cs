using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

namespace AlgoWorld
{

    public interface IFirstAlgorithmRunner
    {
        public bool Run();
        public void SetCharacters(Character[] characters);

        public bool CheckForNameDuplication();
    }
    public class FirstAlgorithmRunner : IFirstAlgorithmRunner
    {
        private Character[]? _characters;
        public bool Run()
        {
            
            return CheckForNameDuplication();
        }

        public void SetCharacters(Character[] characters)
        {
            _characters = characters;
        }

        public bool CheckForNameDuplication()
        {
            Dictionary<string, int> namesAlreadySeen = new Dictionary<string, int>();
            for(int i = 0; i < _characters?.Length; i++)
            {
                if (namesAlreadySeen.ContainsKey(_characters[i]?.GetName())){
                    return true;
                }
                else
                {
                    namesAlreadySeen.Add(_characters[i]?.GetName(), 1);
                }
            }
            return false;
        }
    }
}