using System.Numerics;

public class StrOps
{
    public void Reversal(string s)
    {
        string n = string.Empty;
        for (int i = (s.Length - 1); i > -1 ; i--)
        {
            n += s[i];
        }
        Console.WriteLine(n);
    }
}