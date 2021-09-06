public class TwoSum_1{
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int, List<int>>();
        
        // Add all the values and their indices
        for(int i = 0; i < nums.Length; i++)
        {
            if(map.ContainsKey(nums[i])) map[nums[i]].Add(i);
            else map.Add(nums[i], new List<int>(){i});
        }
        
        foreach(var kvp in map)
        {
            int b = target - kvp.Key;
            
            // We found a hit
            if(map.ContainsKey(b))
            {
                // If the value b is different then we're done
                if(kvp.Key != b) return new int[] {kvp.Value[0], map[b][0]};
                
                // If the value b is the same then we need to make sure the index isn't the same
                if(kvp.Key == b && kvp.Value.Count > 1) return new int[]{kvp.Value[0], kvp.Value[1]};
            }
        }
        
        return new int[]{};
    }
}