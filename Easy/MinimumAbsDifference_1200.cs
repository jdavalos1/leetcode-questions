public class MinimumAbsDifference_1200{
    public IList<IList<int>> MinimumAbsDifference(int[] arr) {
        Array.Sort(arr);
        
        int absMinValue = Int32.MaxValue;
        int tempValue = 0;
        
        IList<IList<int>> pairs = new List<IList<int>>();
        
        // Iterate through the array
        // Remember the last value cannot match with any other
        // but its previous value
        for(int i = 0; i < arr.Length - 1; i++)
        {
            // Check if a new diff is smaller than the previous
            // else check if equal
            tempValue = Math.Abs(arr[i + 1] - arr[i]);
            if(tempValue < absMinValue)
            {
                // Clear the list since all pairs in the list
                // have abs min greater than the new min
                // add the new pair as well
                pairs.Clear();
                absMinValue = tempValue;
                pairs.Add(new List<int>() {arr[i], arr[i+1]});
            }
            else if(tempValue == absMinValue)
            {
                // Found a pair that works so add to list
                pairs.Add(new List<int>() {arr[i], arr[i+1]});
            }
        }
        
        return pairs;
    }
}