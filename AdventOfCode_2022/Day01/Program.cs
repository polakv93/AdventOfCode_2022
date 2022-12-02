var maxCalories = 0;
var sumOfCurrentCalories = 0;
foreach (var line in File.ReadLines("./input.txt"))
{
    if (string.IsNullOrWhiteSpace(line))
    {
        if (sumOfCurrentCalories > maxCalories)
        {
            maxCalories = sumOfCurrentCalories;
        }

        sumOfCurrentCalories = 0;
    }
    else
    {
        sumOfCurrentCalories += int.Parse(line);
    }
}

Console.WriteLine(maxCalories);