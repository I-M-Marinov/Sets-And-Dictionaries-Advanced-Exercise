Dictionary<int, int> numbersCount = new();

int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (!numbersCount.ContainsKey(number))
    {
        numbersCount.Add(number, 0);
    }

    numbersCount[number]++;
}

Console.WriteLine(numbersCount.Single(nc => nc.Value % 2 == 0).Key);
