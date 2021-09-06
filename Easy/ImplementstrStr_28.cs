public class ImplementstrStr_28{
    public int StrStr(string haystack, string needle) {
        if(needle.Length == 0) return 0;
        
        int j,
            hLength = haystack.Length,
            nLength = needle.Length;
        
        if(nLength > hLength) return -1;
        
        for(int i = 0; i <= hLength - nLength; i++){
            for(j = 0; j < nLength && haystack[i + j] == needle[j]; j++);
            
            if(j == nLength) return i;
        }
        
        return -1;
    }
}