using System.Text;

using BenchmarkDotNet.Attributes;

namespace RandomPassword;

[MemoryDiagnoser()]
public class RandomString
{
    
    [Benchmark]
    public string Generate()
    {
        StringBuilder builder = new();
        Random random = new();
        char ch;
        for (int i = 0; i < 4; i++)
        {

            ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
            builder.Append(ch);
        }

        var num = random.Next(100, 1000);

        if (num % 2 == 0)
        {
            builder.Insert(0, num);
        }
        else
        {
            builder.Append(num);
        }

        num = DateTime.Now.Millisecond;

        if (num % 2 == 0)
        {
            builder.Insert(0, DateTime.Now.Second);
        }
        else
        {
            builder.Append(DateTime.Now.Second);
        }

        return builder.ToString();
    }

    [Benchmark]
    public string GenerateString()
    {
        string str = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        StringBuilder builder = new();
        Random rnd = new();
        for (int i = 0; i < 10; i++)
        {
            builder.Append(str[rnd.Next(0, str.Length)]);
        }
        return builder.ToString();
    }
    
    public HashSet<string> GenerateRandomString()
    {
        int count = 1000000;
        HashSet<string> randomStrings = new();
        for (int i = 0; i < count; i++)
        {
            randomStrings.Add(Generate());
        }
        return randomStrings;
    }
}