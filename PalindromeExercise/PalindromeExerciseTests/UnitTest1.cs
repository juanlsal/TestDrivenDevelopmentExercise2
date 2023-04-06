using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("tacocat", true)]
        [InlineData("Juan", false)]
        [InlineData("Yelley", true)]
        [InlineData("Neven", true)]
        [InlineData("Kelly", false)]
        [InlineData("Ava", true)]
        [InlineData("Ciric", true)]
        [InlineData("aa", true)]
        public void IsAPalidromeTest(string word, bool expected)
        {
            var tester = new WordSmith();

            var actual = tester.IsAPalidrome(word);

            Assert.Equal(expected, actual);

        }
    }
}
