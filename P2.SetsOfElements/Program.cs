int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int numberOfFirstElements = input[0];
int numberOfSecondElements = input[1];

HashSet<int> firstSet = new();
HashSet<int> secondSet = new();
HashSet<int> allElementsSet = new();

for (int i = 0; i < numberOfFirstElements; i++)
{
    firstSet.Add(int.Parse(Console.ReadLine()));
}

for (int i = 0; i < numberOfSecondElements; i++)
{
    secondSet.Add(int.Parse(Console.ReadLine()));
}


foreach (var number in firstSet)
{
    if (secondSet.Contains(number))
    {
        allElementsSet.Add(number);
    }
}

foreach (var number in allElementsSet)
{
    Console.Write($"{number} ");
}