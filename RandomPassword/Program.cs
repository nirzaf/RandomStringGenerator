using RandomPassword;

Console.WriteLine("Testing Random String Generator....");

var stringList = new List<string>();

int count = 5000000;

for (int i = 0; i < count; i++)
{
    stringList.Add(RandomString.Generate());
}

//find all duplicates in the list and print them

var duplicates = stringList.GroupBy(x => x)
                           .Where(g => g.Count() > 1)
                           .Select(y => y.Key)
                           .ToList();

Console.WriteLine(duplicates.Count > 0
    ? $"{duplicates.Count} : Duplicates found in {count} strings"
    : $"No duplicates found in {count} strings");

Console.ReadLine();

