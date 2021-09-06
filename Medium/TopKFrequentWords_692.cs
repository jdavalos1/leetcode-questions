using System;
using System.Collections.Generic;

public class TopKFrequentWords_692{
    public IList<string> TopKFrequent(string[] words, int k) {
        var map = new Dictionary<string, int>();
        
        foreach(var word in words)
        {
            if(map.ContainsKey(word))
                map[word]++;
            else
                map.Add(word, 1);
        }
        
        var topK = map.Keys.ToList();
        topK.Sort((s1, s2) =>
                  {
                      if(map[s1] > map[s2]) return -1;
                      if(map[s1] < map[s2]) return 1;
                      else return s1.CompareTo(s2);
                  });
        return topK.GetRange(0, k);
    }
    
}