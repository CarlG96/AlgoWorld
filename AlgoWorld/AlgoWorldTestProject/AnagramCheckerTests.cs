using AlgoWorld;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoWorldTestProject
{
    
    public class AnagramCheckerTests
    {
        [Fact]
        public void ShouldReturnFalseWhenNotAnAnagram()
        {
            AnagramChecker anagramChecker = new AnagramChecker();
            bool answer = anagramChecker.CheckAnagram("LordHood", "GoodLord");
            answer.Should().BeFalse();
        }

        [Fact]
        public void ShouldReturnTrueWhenIsAnAnagram()
        {
            AnagramChecker anagramChecker = new AnagramChecker();
            bool answer = anagramChecker.CheckAnagram("LordHood", "HoodLord");
            answer.Should().BeTrue();
        }

        [Fact]

        public void ShouldReturnTrueWhenNotSameSize()
        {
            AnagramChecker anagramChecker = new AnagramChecker();
            bool answer = anagramChecker.CheckAnagram("LordHood", "Monk");
            answer.Should().BeFalse();
        }

        [Fact]

        public void ShouldReturnTruePartTwo()
        {

            AnagramChecker anagramChecker = new AnagramChecker();
            bool answer = anagramChecker.CheckAnagram("Sir Algor Riddime", "emiddiR roglA riS");
            answer.Should().BeTrue();
        }

        [Fact]
        public void ShouldReturnTruePartThree()
        {
            AnagramChecker anagramChecker = new AnagramChecker();
            bool answer = anagramChecker.CheckAnagram("Grixix", "xiirxG");
            answer.Should().BeTrue();
        }
    }
}
