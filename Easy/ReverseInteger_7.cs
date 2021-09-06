public class ReverseInteger_7{
    public int Reverse(int x) {
        var flipped = Flip(x);
        bool neg = x < 0;
        
        if(TooLarge(flipped, neg)) return 0;
        
        return Int32.Parse(flipped) * (neg ? -1 : 1);
    }
    
    // reverse the characters
    private string Flip(int x)
    {
        char[] xVals = x.ToString().Replace("-", "").ToCharArray();
        
        
        for(int i = 0, j = xVals.Length - 1; i < j; i++, j--)
        {
            var temp = xVals[i];
            xVals[i] = xVals[j];
            xVals[j] = temp;
        }
        
        return new string(xVals);
    }
    
    private bool TooLarge(string val, bool neg)
    {
        // Smaller than 1 billion so good to go
        if(val.Length < 10) return false;
        
        var largest = neg ? Int32.MaxValue.ToString() : Int32.MinValue.ToString().Replace("-", "");
        
        for(int i = 0; i < val.Length; i++)
        {
            var subVal = val.Substring(0, i + 1);
            var subLarge = largest.Substring(0, i + 1);
            
            var compare = String.Compare(subVal, subLarge);
            
            // if > then subVal > subLarge if < 0 subVal < subLarge and good to go
            // else continue since they equal so far
            if(compare > 0) return true;
            else if(compare < 0) return false;
        }
        
        return false;
    }
}