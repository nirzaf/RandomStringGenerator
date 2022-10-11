using RandomPassword;

Console.WriteLine("Testing Random String Generator....");

var begin = DateTime.Now;

HashSet<string> hashList1 = new HashSet<string>();
HashSet<string> hashList2 = new HashSet<string>();

int count = 1000000; // 1 million

for (int i = 0; i < count; i++)
{
    hashList1.Add(RandomString.Generate());
    hashList2.Add(RandomString.GenerateString());
}


//print 3 strings from both list 
Console.WriteLine("RandomString.Generate()");
foreach (var item in hashList1.Take(3))
{
    Console.WriteLine(item);
}

Console.WriteLine("RandomString.GenerateString()");
foreach (var item in hashList2.Take(3))
{
    Console.WriteLine(item);
}

Console.WriteLine(hashList1.Count == count
    ? $"No duplicates found using RandomString.Generate() out of {count} strings"
    : $"{count - hashList1.Count} Duplicates found using RandomString.Generate() out of {count} strings");

Console.WriteLine(hashList2.Count == count
    ? $"No duplicates found using RandomString.GenerateString() out of {count} strings"
    : $"{count - hashList2.Count} Duplicates found using RandomString.GenerateString() out of {count} strings");

var end = DateTime.Now;

Console.WriteLine($"Time taken: {end - begin}");

Console.ReadLine();