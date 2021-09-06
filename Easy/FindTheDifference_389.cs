public class FindTheDifference_389{
    public char FindTheDifference(string s, string t) {
        int total = 0;
        
        foreach(var c in t) total += (int)c;
        foreach(var c in s) total -= (int)c;
        
        return (char)total;
    }
}