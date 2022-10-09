using RandomPassword;

Console.WriteLine("Testing Random String Generator....");

// Generate a list of random string and check if there are any duplicates

var stringList = new List<string>();

var begin = DateTime.Now;

for (int i = 0; i < 5000000; i++)
{
    stringList.Add(RandomString.Generate());
}

//find all duplicates in the list and print them

var duplicates = stringList.GroupBy(x => x)
                           .Where(g => g.Count() > 1)
                           .Select(y => y.Key)
                           .ToList();

Console.WriteLine(duplicates.Count > 0 ? $"{duplicates.Count} : Duplicates found" : "No duplicates found");

//print the first 10 items in the list

Console.WriteLine(string.Join(",  ", stringList.Take(10)));

var end = DateTime.Now;

Console.WriteLine($"Total Time taken: {end - begin}");

Console.ReadLine();

