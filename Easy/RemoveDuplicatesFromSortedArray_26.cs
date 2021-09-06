public class RemoveDuplicatesFromSortedArray_26{
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length == 0) return 0;
        
        int i = 0,
            j = 1;
        
        while(j < nums.Length)
        {
            while(j < nums.Length && nums[j] == nums[i]) j++;
            
            if(j < nums.Length)
            {
                i++;
                var temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
                j++;
            }
        }
        
        return i + 1;
    }
}