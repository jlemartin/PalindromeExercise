using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("Racecar", true)]
        [InlineData("Eve", true)]
        [InlineData("MadamImAdam", true)]
        [InlineData("firetruck", false)]
        [InlineData("madam", true)]
        public void IsAPalindrome(string word, bool expected)
        {
            // Arrange
            var test = new WordSmith();

            // Act
            var actual = test.IsAPalindrome(word);

            // Assert
            Assert.Equal(expected, actual);

        }
    }
}
