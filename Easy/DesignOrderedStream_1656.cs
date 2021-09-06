using System;
using System.Collections.Generic;

public class DesignOrderedStream_1656{
    int ptr;
    string[] values;
    public OrderedStream(int n) {
        ptr = 0;
        values = new string[n];
    }
    
    public IList<string> Insert(int idKey, string value) {
        values[idKey - 1] = value;
        
        var temp = new List<string>();
        
        while(ptr < values.Length && !String.IsNullOrEmpty(values[ptr])){
            temp.Add(values[ptr++]);
        }
        
        return temp;
    }
}

/**
 * Your OrderedStream object will be instantiated and called as such:
 * OrderedStream obj = new OrderedStream(n);
 * IList<string> param_1 = obj.Insert(idKey,value);
 */