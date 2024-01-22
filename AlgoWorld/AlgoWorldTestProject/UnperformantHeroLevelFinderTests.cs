using AlgoWorld;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoWorldTestProject
{
    public class UnperformantHeroLevelFinderTests
    {
        [Fact]
        public void ShouldReturnZeroAndOne()
        {
            UnperformantHeroLevelFinder unperformantHeroLevelFinder = new UnperformantHeroLevelFinder();
            int[] answers = unperformantHeroLevelFinder.FindHeroIndexes(new int[] { 1, 2 }, 3);
            answers[0].Should().Be(0);
            answers[1].Should().Be(1);
        }

        [Fact]

        public void ShouldReturnZeroAndFive()
        {
            UnperformantHeroLevelFinder unperformantHeroLevelFinder = new UnperformantHeroLevelFinder();
            int[] answers = unperformantHeroLevelFinder.FindHeroIndexes(new int[] { 5, 3, 4, 1, 2, 9 }, 14);
            answers[0].Should().Be(0);
            answers[1].Should().Be(5);
        }

        [Fact]
        public void ShouldReturnMinusOneAndMinusOne()
        {
            UnperformantHeroLevelFinder unperformantHeroLevelFinder = new UnperformantHeroLevelFinder();
            int[] answers = unperformantHeroLevelFinder.FindHeroIndexes(new int[] { 5, 3, 4, 1, 2, 9 }, 10000);
            answers[0].Should().Be(-1);
            answers[1].Should().Be(-1);
        }
    }
}
