public class ReverseOnlyLetters_917{
    public string ReverseOnlyLetters(string S) {
        var letters = S.ToCharArray();
        int first = 0,
            second = S.Length - 1;
        
        bool done = false;
        
        while(!done)
        {
            while(first < S.Length && !Char.IsLetter(letters[first])) first++;
            while(second > 0 && !Char.IsLetter(letters[second])) second--;
            
            if(first < second)
            {
                var temp = letters[first];
                letters[first] = letters[second];
                letters[second] = temp;
                first++;
                second--;
            }
            else
            {
                done = true;
            }
        }
        return new string(letters);
    }
    
}