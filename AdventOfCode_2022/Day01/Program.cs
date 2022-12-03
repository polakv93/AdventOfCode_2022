IEnumerable<string> ReadLines()
{
    foreach (var line in File.ReadLines("./input.txt"))
    {
        yield return line;
    }

    yield return string.Empty;
}

var log = new List<int>();
var sumOfCurrentCalories = 0;
foreach (var line in ReadLines())
{
    if (string.IsNullOrWhiteSpace(line))
    {
        log.Add(sumOfCurrentCalories);
        sumOfCurrentCalories = 0;
    }
    else
    {
        sumOfCurrentCalories += int.Parse(line);
    }
}

Console.WriteLine(log.OrderDescending().Take(3).Sum());