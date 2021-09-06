using System;
using System.Collections.Generic;
public class NumberOfGoodPairs_1512{
    public int NumIdenticalPairs(int[] nums) {
        var pairList = new Dictionary<int, int>();
        
        foreach(int i in nums){
            if(!pairList.ContainsKey(i)){
                pairList.Add(i, 1);
            } else {
                pairList[i]++;
            }
        }
        
        int totalCount = 0;
        
        foreach(var pair in pairList){
            int n = pair.Value;
            totalCount +=  n * (n - 1) / 2;
        }
        return totalCount;
    }
}