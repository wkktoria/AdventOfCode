using NUnit.Framework.Legacy;

namespace AoC_2015.Test;

class Day_02Test : Day_02
{
    public override string InputFilePath => "TestInputs/02.txt";
}

public class Day02Tests
{
    [Test]
    public async Task SampleInput()
    {
        const string solution1 = "58";
        const string solution2 = "34";

        var day = new Day_02Test();

        ClassicAssert.AreEqual(solution1, await day.Solve_1());
        ClassicAssert.AreEqual(solution2, await day.Solve_2());
    }
}
