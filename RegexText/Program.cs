using System.Text.RegularExpressions;

string matn = "AA@%^&CC";
string yangilanganQator = Regex.Replace(matn, @"[^a-zA-Z0-9_ ]", "");
Console.WriteLine(yangilanganQator);