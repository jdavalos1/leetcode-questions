public class KthLargestElementInStream_703 {
    
    int[] largestK;
    
    public KthLargest(int k, int[] nums) {
        
        largestK = new int[k + 1];
        
        for(int i = 0; i < largestK.Length; i++) largestK[i] = Int32.MinValue;
        
        for(int i = 0; i < nums.Length; i++)
        {
            largestK[0] = nums[i];
            SortArray();
        }
    }
    public int Add(int val) {
        largestK[0] = val;
        SortArray();
        return largestK[1];
    }
    
    // Sort with newest element inserted at position 0
    private void SortArray()
    {
        // Sort to find the new kth largest to largest numbers
        for(int i = 1; i < largestK.Length; i++)
        {
            if(largestK[i-1] > largestK[i])
            {
                Swap(i-1, i);
            }
            else return;
        }
    }
    
    // Swap helper function
    private void Swap(int i, int j)
    {
        var temp = largestK[i];
        largestK[i] = largestK[j];
        largestK[j] = temp;
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */