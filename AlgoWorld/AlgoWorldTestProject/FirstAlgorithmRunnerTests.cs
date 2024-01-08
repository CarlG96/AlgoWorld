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
            bool value = firstAlgorithmRunner.Run();
            value.Should().BeFalse();
        }

        [Fact]
        public void ShouldReturnTrueWhenThereAreDuplicateNames()
        {
            Mock<IFirstAlgorithmRunner> firstAlgorithmRunner = new Mock<IFirstAlgorithmRunner>();
            firstAlgorithmRunner.Setup(m => m.GenerateCharacters()).Returns(new Character[]
            {
                new Character("Algor Riddime", Race.Human, 10),
                new Character("Algor Riddime", Race.Human, 10)
            });
            bool value = firstAlgorithmRunner.Object.Run();
            value.Should().BeTrue();
        }
    }
}