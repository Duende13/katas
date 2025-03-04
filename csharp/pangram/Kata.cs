using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
public static class Kata
{
    public static bool IsPangram(string str)
    {
        str = Regex.Replace(str.ToLower(), "[^a-z]+", "");
        HashSet<char> set = new HashSet<char>(str);   
        return set.Count == 26;
    }
}