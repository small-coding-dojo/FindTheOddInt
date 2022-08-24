using System.Collections.Generic;
using System.Linq;

namespace FindTheOddInt.Tests;

public static class Kata
{
    public static int find_it(int[] seq)
    {
        var occurrences = CountOccurrencesByNumber(seq);
        return FindNumberOccurringOddNumberOfTimes(occurrences);
    }

    public static int find_it_extreme(int[] seq)
    {
        return seq.Aggregate(0, (current, num) => current ^ num);
    }

    private static Dictionary<int, int> CountOccurrencesByNumber(int[] seq)
    {
        var occurrences = seq.ToHashSet().ToDictionary(x => x, y => 0);
        seq.ToList().ForEach(num => occurrences[num]++);
        return occurrences;
    }

    private static int FindNumberOccurringOddNumberOfTimes(Dictionary<int, int> occurrences)
    {
        return occurrences.First(x => IsOdd(x.Value)).Key;
    }


    private static bool IsOdd(int x)
    {
        return x % 2 != 0;
    }
}