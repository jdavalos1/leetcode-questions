public class LongestCommonPrefix_14{
    public string LongestCommonPrefix(string[] strs) {
        string longPrefix = "";
        bool done = false;
        int i = 0;
        
        while(!done)
        {
            if(i + 1 > strs[0].Length) return longPrefix;
            
            char curr = strs[0][i];
            
            foreach(var str in strs)
            {
                if(i + 1 > str.Length || str[i] != curr)
                {
                    done = true;
                    break;
                }
            }
            
            if(!done) longPrefix += strs[0][i];
            i++;
        }
        
        return longPrefix;
    }
}