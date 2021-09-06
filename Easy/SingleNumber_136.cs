public class SingleNumber_136{
    public int SingleNumber(int[] nums) {
        Array.Sort(nums);
        
        int value = 0;
        for(int i = 0; i < nums.Length; i += 2)
        {
            if(i + 1 >= nums.Length || nums[i] != nums[i + 1])
            {
                value = nums[i];
                break;
            } 
        }
        return value;
    }
}