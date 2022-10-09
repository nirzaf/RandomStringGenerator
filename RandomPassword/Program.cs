using BenchmarkDotNet.Running;

using RandomPassword;

Console.WriteLine("Testing Random String Generator....");

var begin = DateTime.Now;
//
// HashSet<string> hashList = new HashSet<string>();
//
// int count = 10000000; // 10 million
//
// for (int i = 0; i < count; i++)
// {
//     hashList.Add(RandomString.Generate());
// }

var summary = BenchmarkRunner.Run<RandomString>();

// Console.WriteLine(hashList.Count == count ? "No duplicates found" : $"{count - hashList.Count} Duplicates found");

// var end = DateTime.Now;
//
// Console.WriteLine($"Time taken: {end - begin} and { (end-begin) / hashList.Count* 1000} millisecond taken per string generated");

Console.ReadLine();

