SortedDictionary<char, int> characterCount = new();

string input = Console.ReadLine();

foreach (var character in input)
{
    if (!characterCount.ContainsKey(character))
    {
        characterCount.Add(character, 0);
    }

    characterCount[character]++;
}

foreach (var charCount in characterCount)
{
    Console.WriteLine($"{charCount.Key}: {charCount.Value} time/s");
}