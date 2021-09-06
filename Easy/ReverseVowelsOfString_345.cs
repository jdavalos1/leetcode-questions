public class ReverseVowelsOfString_345{
    public string ReverseVowels(string s) {
        char[] str = s.ToCharArray();
        int i = 0,
            j = s.Length - 1;
        
        while(i < j)
        {
            bool fVowel = isVowel(str[i]);
            bool bVowel = isVowel(str[j]);
            
            if(!fVowel) i++;
            if(!bVowel) j--;
            
            if(fVowel && bVowel)
            {
                var temp = s[i];
                str[i] = str[j];
                str[j] = temp;
                i++;
                j--;
            }
        }
        
        return new string(str);
    }
    
    private bool isVowel(char c)
    {
        return "aeiouAEIOU".Contains(c);
    }
}