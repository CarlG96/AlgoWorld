using AlgoWorld;
using FluentAssertions;
using Moq;

namespace AlgoWorldTestProject
{
    public class FirstAlgorithmRunnerTests
    {
        [Fact]
        public void ShouldReturnFalseInNormalRun()
        {
            FirstAlgorithmRunner firstAlgorithmRunner = new FirstAlgorithmRunner();
            firstAlgorithmRunner.SetCharacters(new Character[] { new Character("Algor Riddime", Race.Human, 25), new Character("Big Graff", Race.Giant, 12), new Character("Small Graff", Race.Halfling, 88) });
            bool value = firstAlgorithmRunner.Run();
            value.Should().BeFalse();
        }

        [Fact]
        public void ShouldReturnTrueWhenThereAreDuplicateNames()
        {
            FirstAlgorithmRunner firstAlgorithmRunner = new FirstAlgorithmRunner();
            firstAlgorithmRunner.SetCharacters(new Character[] { new Character("Algor Riddime", Race.Human, 25), new Character("Algor Riddime", Race.Human, 25) });

            bool value = firstAlgorithmRunner.Run();
            value.Should().BeTrue();
        }
    }
}