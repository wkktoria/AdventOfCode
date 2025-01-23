using NUnit.Framework.Legacy;

namespace AoC_2015.Test;

class Day_01Test : Day_01
{
    public override string InputFilePath => "TestInputs/01.txt";
}

public class Day01Tests
{
    [Test]
    public async Task SampleInput()
    {
        const string solution1 = "-1";
        const string solution2 = "5";

        var day = new Day_01Test();

        ClassicAssert.AreEqual(solution1, await day.Solve_1());
        ClassicAssert.AreEqual(solution2, await day.Solve_2());
    }
}
