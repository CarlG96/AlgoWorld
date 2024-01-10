using AlgoWorld;
using FluentAssertions;
using Moq;

namespace AlgoWorldTestProject
{
    public class UniqueNameCheckerTests
    {
        [Fact]
        public void ShouldReturnFalseInNormalRun()
        {
            UniqueNameChecker uniqueNameChecker = new UniqueNameChecker();
            uniqueNameChecker.SetCharacters(new Character[] { new Character("Algor Riddime", Race.Human, 25), new Character("Big Graff", Race.Giant, 12), new Character("Small Graff", Race.Halfling, 88) });
            bool value = uniqueNameChecker.CheckForNameDuplication();
            value.Should().BeFalse();
        }

        [Fact]
        public void ShouldReturnTrueWhenThereAreDuplicateNames()
        {
            UniqueNameChecker uniqueNameChecker = new UniqueNameChecker();
            uniqueNameChecker.SetCharacters(new Character[] { new Character("Algor Riddime", Race.Human, 25), new Character("Algor Riddime", Race.Human, 25) });

            bool value = uniqueNameChecker.CheckForNameDuplication();
            value.Should().BeTrue();
        }
    }
}