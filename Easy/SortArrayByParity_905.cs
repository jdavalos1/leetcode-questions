public class SortArrayByParity_905{
    public int[] SortArrayByParity(int[] nums) {
        int i = 0,
            j = nums.Length - 1;
        
        while(i < j)
        {
            if(nums[i] % 2 == 1)
            {
                if(nums[j] % 2 == 0)
                {
                    Swap(nums, i, j);
                    i++;
                }
                j--;
            }
            else
            {
                if(nums[j] % 2 == 1) j--;
                i++;
            }
        }
        
        return nums;
    }
    
    private void Swap(int[] nums, int i, int j)
    {
        var temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}