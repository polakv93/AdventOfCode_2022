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


foreach (var line in File.ReadLines("./input.txt"))
{
    var mid = line.Length / 2;
    var first = line.Take(mid);
    var second = line.Skip(mid);

    var intersected = first.Intersect(second);
    foreach (var c in intersected)
    {
        score += priorities[c];
    }
}

Console.WriteLine(score);