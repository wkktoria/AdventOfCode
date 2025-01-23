using Common;

namespace AoC_2015;

public class Day_01 : Base2015Day
{
    private readonly string _input;

    public Day_01()
    {
        _input = File.ReadAllText(InputFilePath);
    }

    public override ValueTask<string> Solve_1()
    {
        var arr = _input.ToCharArray();
        var openingCount = arr.Count(p => p == '(');
        var closingCount = arr.Count(p => p == ')');

        var result = openingCount - closingCount;

        return new(result.ToString());
    }

    public override ValueTask<string> Solve_2()
    {
        var currentFloor = 0;
        var arr = _input.ToCharArray();

        for (var i = 0; i < arr.Length; i++)
        {
            if (arr[i] == '(')
            {
                currentFloor++;
            }
            else if (arr[i] == ')')
            {
                currentFloor--;
            }

            if (currentFloor == -1)
            {
                return new((i + 1).ToString());
            }
        }

        return new("no solution");
    }
}