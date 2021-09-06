public class LengthOfLastWord_58{
    public int LengthOfLastWord(string s) {
        var sSplit = s.Trim(' ').Split(' ');
        
        return sSplit.Length == 0 ? 0 : sSplit[sSplit.Length - 1].Length;
    }
}