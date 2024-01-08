using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

namespace AlgoWorld
{

    public interface IFirstAlgorithmRunner
    {
        public bool Run();
        public Character[] GenerateCharacters();

        public bool CheckForNameDuplication();
    }
    public class FirstAlgorithmRunner : IFirstAlgorithmRunner
    {
        private Character[]? _characters;
        public bool Run()
        {
            _characters = GenerateCharacters();
            return CheckForNameDuplication();
        }

        public Character[] GenerateCharacters()
        {
            return new Character[] {new Character("Algor Riddime", Race.Human, 25), new Character("Algor Riddime", Race.Dwarf, 38), new Character("Big Graff", Race.Giant, 12), new Character("Small Graff", Race.Halfling, 88) };
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