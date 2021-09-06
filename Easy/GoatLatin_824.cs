public class GoatLatin_824 
{
    public string ToGoatLatin(string S) 
    {
        string[] vowels = {"a", "e", "i", "o", "u"};
        var words = S.Split(' ');
        var a = "a";
        
        for(var i = 0; i < words.Length; i++)
        {
            var firstLetter = words[i].Substring(0, 1);
            
            if(vowels.Contains(firstLetter.ToLower()))
            {
                words[i] += "ma";
            }
            else
            {
                words[i] = words[i].Remove(0,1);
                words[i] += firstLetter + "ma";
            }
            
            words[i] += a;
            a += "a";
        }
        return string.Join(" ", words);
    }
               
}