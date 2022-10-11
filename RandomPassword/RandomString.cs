using System.Text;

namespace RandomPassword;

public static class RandomString
{
    public static string Generate()
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

    public static string GenerateString()
    {
        const string str = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        StringBuilder builder = new();
        Random random = new();
        for (int i = 0; i < 11; i++)
        {
            builder.Append(str[random.Next(0, str.Length)]);
        }
        return builder.ToString();
    }
}