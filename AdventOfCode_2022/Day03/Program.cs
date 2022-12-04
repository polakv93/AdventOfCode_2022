var priorities = new Dictionary<char, int>();

var i = 'a';
var priority = 1;
while (i <= 'z')
{
    priorities.Add(i, priority);
    priority++;
    i++;
}

i = 'A';
while (i <= 'Z')
{
    priorities.Add(i, priority);
    priority++;
    i++;
}

var score = 0;

foreach (var group in File.ReadLines("./input.txt").Chunk(3))
{
    var intersected = group[0].Intersect(group[1]).Intersect(group[2]);
    foreach (var c in intersected)
    {
        score += priorities[c];
    }
}

Console.WriteLine(score);