
int numberOfInputLines = int.Parse(Console.ReadLine());
List<string> chemicalCompounds = new();
SortedSet<string> chemicalCompoundsSet = new();

for (int i = 0; i < numberOfInputLines; i++)
{
    chemicalCompounds = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

    for (int j = 0; j < chemicalCompounds.Count; j++)
    {
        chemicalCompoundsSet.Add(chemicalCompounds[j]);
    }
    
}

foreach (var chemical in chemicalCompoundsSet)
{
    Console.Write($"{chemical} ");
}
