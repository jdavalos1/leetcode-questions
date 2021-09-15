public class MaximumSubarray_53
{
    public int MaxSubArray(int[] nums) {
        int bs = Int32.MinValue;
        int cs = 0;
        
        foreach(var n in nums)
        {
            cs = Math.Max(n, cs + n);
            bs = Math.Max(bs, cs);
        }
        
        return bs;
    }
}