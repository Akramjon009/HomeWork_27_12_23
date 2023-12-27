using System.Text.RegularExpressions;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(IsMatch("aa", "a"));

    }
    public static bool IsMatch(string s, string p)
    {
        Regex regex = new Regex($"^{p}$");
        return regex.IsMatch(s);
    }
}
