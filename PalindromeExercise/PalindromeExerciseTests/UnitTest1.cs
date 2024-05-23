using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("wow", true)]
        [InlineData("hey", false)]
        [InlineData("a santa at nasa", true)]
        [InlineData("how are you", false)]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData("Was it a car or a Cat I saw", true)]

        public void IsAPalindromeTest(string example, bool expected)
        {
            var wordSmith = new WordSmith();

            var actual = wordSmith.IsAPalindrome(example);

            Assert.Equal(expected, actual);
        }

    }
}
