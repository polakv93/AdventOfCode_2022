var scores = new Dictionary<char, int>
{
    { 'A', 1 },
    { 'B', 2 },
    { 'C', 3 }
};

var charShift = 'X' - 'A';

var score = 0;
const char rock = 'A';
const char paper = 'B';
const char scissors = 'C';

foreach (var line in File.ReadLines("./input.txt"))
{
    var opponent = line[0];
    var my = (char)(line[2] - charShift);
    score += scores[my];

    if (my == opponent)
    {
        score += 3;
        continue;
    }
    if ((my == rock && opponent == scissors )||
        (my == scissors && opponent == paper )||
        (my == paper && opponent == rock))
    {
        score += 6;
        continue;
    }
}

Console.WriteLine(score);