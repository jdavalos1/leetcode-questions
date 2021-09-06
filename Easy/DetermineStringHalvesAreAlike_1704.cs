public class DetermineStringHalvesAreAlike_1704{
    private List<char> vowelList = new List<char>() {
        'a', 'e', 'i', 'o', 'u',
    };
    
    public bool HalvesAreAlike(string s) {
        int total = 0;
        int half = s.Length / 2;
        var a = s.Substring(0, half);
        var b = s.Substring(half, half);
        
        for(int i = 0; i < half; i++)
        {
            if(isVowel(a[i])) total++;
            if(isVowel(b[i])) total--;
        }
        
        return total == 0;
    }
    
    private bool isVowel(char c)
    {
        return vowelList.Contains(Char.ToLower(c));
    }
}