using System;
using System.Collections.Generic;

public class MakeTwoArrayEqualByReversingSubArray_1460{
    public bool CanBeEqual(int[] target, int[] arr) {
        var targetDict = new Dictionary<int, int>();
        int i;
        
        for(i = 0; i < target.Length; i++)
        {
            if(!targetDict.ContainsKey(target[i]))
            {
                targetDict.Add(target[i], 1);
            }
            else
            {
                targetDict[target[i]] += 1;
            }
        }
        
        for(i = 0; i < arr.Length; i++)
        {
            if(!targetDict.ContainsKey(arr[i]))
            {
                return false;
            }
            else
            {
                targetDict[arr[i]] -= 1;
            }
        }
        
        foreach(var kvp in targetDict)
        {
            if(kvp.Value != 0) return false;
        }
        
        return true;
    }
}