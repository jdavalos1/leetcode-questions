using System.Collections.Generic;

public class ContainsDuplicate_217{
    public bool ContainsDuplicate(int[] nums) {
        Dictionary<int, int> hashMap = new Dictionary<int, int>();
        
        foreach(var i in nums)
        {
            if(!hashMap.ContainsKey(i)) hashMap.Add(i, 1);
            else return true;
        }
        
        return false;
    }
}