public class SearchInsertPosition_35{
    public int SearchInsert(int[] nums, int target) {
        return BinarySearch(nums, target, 0, nums.Length - 1);
    }
    
    private int BinarySearch(int[] nums, int target, int l, int r)
    {
        int c = (int)Math.Floor((l + r) / 2f);
        
        if(nums[c] == target) return c;
        if(target > nums[c])
        {
            if((c + 1) >= nums.Length || target < nums[c+1]) return c + 1;
            
            return BinarySearch(nums, target, c + 1, r);
        }
        else
        {
            if((c - 1) < 0 || target > nums[c - 1]) return c;
            
            return BinarySearch(nums, target, l, c - 1);
        }
    }
}