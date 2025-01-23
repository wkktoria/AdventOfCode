using Common;

namespace AoC_2015;

public class Day_02 : Base2015Day
{
    private readonly string _input;

    public Day_02()
    {
        _input = File.ReadAllText(InputFilePath);
    }

    public override ValueTask<string> Solve_1()
    {
        var total = 0;

        foreach (var line in _input.Split('\n'))
        {
            var dimensions = line.Trim().Split('x');
            var (l, w, h) = (int.Parse(dimensions[0]), int.Parse(dimensions[1]), int.Parse(dimensions[2]));

            var side1 = l * w;
            var side2 = w * h;
            var side3 = h * l;
            var extra = Math.Min(side1, Math.Min(side2, side3));

            total += 2 * side1 + 2 * side2 + 2 * side3 + extra;
        }

        return new(total.ToString());
    }

    public override ValueTask<string> Solve_2()
    {
        var total = 0;

        foreach (var line in _input.Split('\n'))
        {
            var dimensions = line.Trim().Split('x').Select(v => int.Parse(v)).ToArray();
            Array.Sort(dimensions);

            var min1 = dimensions[0];
            var min2 = dimensions[1];
            var volume = dimensions[0] * dimensions[1] * dimensions[2];

            total += min1 + min1 + min2 + min2 + volume;
        }

        return new(total.ToString());
    }
}