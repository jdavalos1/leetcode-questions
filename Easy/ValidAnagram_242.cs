public class ValidAnagram_242{
    public bool IsAnagram(string s, string t) {
        var letters = new Dictionary<char, int>();
        
        // Find all letters
        foreach(char c in s)
        {
            if(letters.ContainsKey(c)) letters[c]++;
            else letters.Add(c, 1);
        }
        

        foreach(char c in t)
        {
            if(letters.ContainsKey(c))
            {
                letters[c]--;
                if(letters[c] == 0) letters.Remove(c);
            }
            else return false;
        }
        
        return letters.Count == 0 ? true : false;
    }
}