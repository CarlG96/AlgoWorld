using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

namespace AlgoWorld
{
    public class FirstAlgorithmRunner
    {
        private Character[]? _characters;
        public void Run()
        {
            generateCharacters();
            Console.WriteLine(this._characters[0].GetName() + this._characters[0].GetRace() + this._characters[0].GetLevel());
        }

        private void generateCharacters()
        {
            this._characters = new Character[] {new Character("Algor Riddime", Race.Human, 25), new Character("Dator Structor", Race.Dwarf, 38), new Character("Big Graff", Race.Giant, 12), new Character("Small Graff", Race.Halfling, 88) };

        }
    }
}