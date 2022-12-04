var overlappingPairs = 0;
foreach (var pairs in File.ReadLines("./input.txt"))
{
    var groups = pairs.Split(',');
    var firstPair = groups[0].Split('-').Select(int.Parse).ToArray();
    var secondPair = groups[1].Split('-').Select(int.Parse).ToArray();
    
    //  f[0]|-------|f[1]
    //    s[0]|---|s[1]
    
    //   f[0]|-|f[1]
    //  s[0]|---|s[1]

    if ((firstPair[0] <= secondPair[0] && firstPair[1] >= secondPair[1]) ||
        (secondPair[0] <= firstPair[0] && secondPair[1] >= firstPair[1]))
    {
        overlappingPairs++;
    }
    
    
}

Console.WriteLine(overlappingPairs);