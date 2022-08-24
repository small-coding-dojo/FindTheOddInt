using FluentAssertions;
using Xunit;

namespace FindTheOddInt.Tests;

public class KataTests
{
    [Theory]
    [InlineData(new []{0}, 0)]
    [InlineData(new []{7}, 7)]

    public void ShouldReturnGivenNumber_BecauseOccursOneTime(int[] input, int expected)
    {
        Kata.find_it(input).Should().Be(expected);
    }
    
    [Theory]
    [InlineData(new []{1,1,2}, 2)]
    [InlineData(new []{0,2,2}, 0)]
    public void ShouldReturnNumberOccurringOnce_BecauseTwoSimilarAndOneUniqueNumber(int[] input, int expected)
    {
        Kata.find_it(input).Should().Be(expected);
    }
    
    [Theory]
    [InlineData(new []{0,1,0,1,0}, 0)]
    [InlineData(new []{1,2,2,3,3,3,4,3,3,3,2,2,1}, 4)]
    [InlineData(new []{20,1,-1,2,-2,3,3,5,5,1,2,4,20,4,-1,-2,5 }, 5)]
    public void ShouldReturnNumberOccurringOddAmountOfTimes(int[] input, int expected)
    {
        Kata.find_it(input).Should().Be(expected);
    }
}