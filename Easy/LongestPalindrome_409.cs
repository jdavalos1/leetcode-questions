using System;
using System.Collections.Generic;

public class LongestPalindrome_409{
    public int LongestPalindrome(string s) {
        var hashSet = new Dictionary<char, int>();
        int total = 0;
        
        foreach(var c in s)
        {
            if(hashSet.ContainsKey(c))
                hashSet[c]++;
            else
                hashSet.Add(c, 1);
        }

        
        foreach(var kvp in hashSet)
        {
            total += kvp.Value / 2 * 2;
            if(total % 2 == 0 && kvp.Value % 2 == 1) total++;
        }
        return total;
    }
}