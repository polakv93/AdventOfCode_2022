var scores = new Dictionary<char, int>
{
    { 'A', 1 },
    { 'B', 2 },
    { 'C', 3 }
};

var score = 0;
const char rock = 'A';
const char paper = 'B';
const char scissors = 'C';

const char loose = 'X';
const char draw = 'Y';
const char win = 'Z';

var resultPoints = new Dictionary<char, int>
{
    { draw, 3 },
    { loose, 0 },
    { win, 6 }
};


foreach (var line in File.ReadLines("./input.txt"))
{
    var opponent = line[0];

    var expectedResult = line[2];

    score += resultPoints[expectedResult];

    score += (expectedResult, opponent) switch
    {
        (loose, rock) => scores[scissors],
        (loose, paper) => scores[rock],
        (loose, scissors) => scores[paper],
        (draw, rock) => scores[rock],
        (draw, paper) => scores[paper],
        (draw, scissors) => scores[scissors],
        (win, rock) => scores[paper],
        (win, paper) => scores[scissors],
        (win, scissors) => scores[rock],
        _ => throw new ArgumentOutOfRangeException()
    };
}

Console.WriteLine(score);