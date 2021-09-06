public class RelativeSortArray_1122{
    public int[] RelativeSortArray(int[] arr1, int[] arr2) {
        Dictionary<int, int> pos = new Dictionary<int, int>();
        
        for(int i = 0; i < arr2.Length; i++) pos.Add(arr2[i], i);
        
        
        Array.Sort(arr1, (a, b) => {
            if(pos.ContainsKey(a) && pos.ContainsKey(b))
            {
                return pos[a].CompareTo(pos[b]);
            }
            else if(!pos.ContainsKey(a) && !pos.ContainsKey(b))
            {
                return a.CompareTo(b);
            }
            else return !pos.ContainsKey(a) ? 1 : -1;
        });
        
        return arr1;
    }
    

}