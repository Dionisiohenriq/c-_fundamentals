namespace System;

public static class StringExtensions
{
    public static string Cut(this string str, int cut)
    {
        if(str.Length <= cut) 
            return str;
        else
            return str.Substring(0, cut) + "...";
    }
}
