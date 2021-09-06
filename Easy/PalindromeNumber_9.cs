public class PalindromeNumber_9{
    public bool IsPalindrome(int x) {
        if(x < 0) return false;
        
        long rev = Reverse(x);
        
        if(rev != x) return false;
        
        return true;
    }
    
    
    private long Reverse(int x)
    {
        long rev = 0;
        
        while(x > 0)
        {
            int rem = x % 10;
            rev = (rev * 10) + rem;
            x = x / 10;
        }
        
        return rev;
    }
}