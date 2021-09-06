public class CheckIfAll1sAreAtLeastKLengthPlacesAway_1437{
    public bool KLengthApart(int[] nums, int k) {
        var count = k;
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 0) count++;
            else
            {
                if(count < k) return false;
                
                else count = 0;
            }
        }
        return true;
    }
}