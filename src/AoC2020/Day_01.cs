using Common;

namespace AoC_2020;

public class Day_01 : Base2020Day
{
    private const int Target = 2020;
    private readonly string _input;
    private readonly int[] _arr;

    public Day_01()
    {
        _input = File.ReadAllText(InputFilePath);
        _arr = [.. _input.Trim().Split('\n').Select(v => int.Parse(v))];
    }

    public override ValueTask<string> Solve_1()
    {
        var dict = new Dictionary<int, int>();

        for (var i = 0; i < _arr.Length; i++)
        {
            var first = _arr[i];
            var second = Target - first;

            if (dict.TryGetValue(second, out var index))
            {
                var result = first * _arr[index];
                return new(result.ToString());
            }

            dict[first] = i;
        }

        return new("no solution");
    }

    public override ValueTask<string> Solve_2()
    {
        Array.Sort(_arr);

        for (var i = 0; i < _arr.Length; i++)
        {
            if (i != 0 && _arr[i - 1] == _arr[i])
            {
                continue;
            }

            for (int start = i + 1, end = _arr.Length - 1; start < end;)
            {
                if (start != i + 1 && _arr[start] == _arr[start - 1])
                {
                    start++;
                    continue;
                }

                if (_arr[i] + _arr[start] + _arr[end] == Target)
                {
                    var result = _arr[i] * _arr[start] * _arr[end];
                    return new(result.ToString());
                }
                else if (_arr[i] + _arr[start] + _arr[end] < Target)
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }
        }

        return new("no solution");
    }
}