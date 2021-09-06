using System;

public class MeanOfArrayAfterRemovingElements_1619{
    public double TrimMean(int[] arr) {
        Array.Sort(arr);
        
        int fivePer = (int)Math.Floor(arr.Length * 0.05);
        int min = fivePer;
        int max = arr.Length - fivePer;
        
        double total = 0;
        for(int i = min; i < max; i++) total += arr[i];
        
        return total/ (max - min);
    }
}