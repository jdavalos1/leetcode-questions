using System;
using System.Collections.Generic;
public class RelativeRanks_506
{
    public string[] FindRelativeRanks(int[] score) {
        SortedDictionary<int, int> h = new SortedDictionary<int, int>();
        int i;
        for(i = 0; i < score.Length; i++)
        {
            h.Add(score[i], i);
        }
        
        string[] relRank = new string[score.Length];
        
        i = 1;
        foreach(var pair in h.Reverse())
        {
            switch(i)
            {
                case 1:
                    relRank[pair.Value] = "Gold Medal";
                    break;
                case 2:
                    relRank[pair.Value] = "Silver Medal";
                    break;
                case 3:
                    relRank[pair.Value] = "Bronze Medal";
                    break;
                default:
                    relRank[pair.Value] = i.ToString();
                    break;
            }
            
            i++;
        }
        
        return relRank;
    }
}