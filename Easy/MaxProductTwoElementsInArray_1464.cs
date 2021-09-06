public class MaxProductTwoElementsInArray_1464{
    public int MaxProduct(int[] nums) {
        int maxVal = Int32.MinValue,
            a = -1,
            b = -1;
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(maxVal < nums[i])
            {
                a = i;
                maxVal = nums[i];
            }
        }
        
        maxVal = Int32.MinValue;
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(maxVal < nums[i])
            {
                if(a != i)
                {
                    b = i;
                    maxVal = nums[i];
                }
            }
        }
        
        return (nums[a] - 1) * (nums[b] - 1);
    }
}