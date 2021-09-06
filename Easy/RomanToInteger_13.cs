public class RomanToInteger_13{
    public int RomanToInt(string s) {
        var map = new Dictionary<int, int>();
        for(var i = s.Length - 1; i >= 0; i--)
        {
            switch(s[i])
            {
                case 'I':
                    CheckWhich(new int[] { 5, 10 }, new int[] {4, 9}, 1, map);
                    break;
                case 'V':
                    if(map.ContainsKey(5)) map[5]++;
                    else map.Add(5, 1);
                    break;
                case 'X':
                    CheckWhich(new int[] {50, 100}, new int[] {40, 90}, 10, map);
                    break;
                case 'L':
                    if(map.ContainsKey(50)) map[50]++;
                    else map.Add(50, 1);
                    break;
                case 'C':
                    CheckWhich(new int[] {500, 1000}, new int[] {400, 900}, 100, map);
                    break;
                case 'D':
                    if(map.ContainsKey(500)) map[500]++;
                    else map.Add(500, 1);
                    break;
                case 'M':
                    if(map.ContainsKey(1000)) map[1000]++;
                    else map.Add(1000, 1);
                    break;
            }
        }
        
        int total = 0;
        foreach(var kvp in map)
        {
            total += kvp.Key * kvp.Value;
        }
        
        return total;
    }
    
    private void CheckWhich(int[] checks, int[] newVals, int currVal, Dictionary<int, int> map)
    {
        if(map.ContainsKey(checks[0]) && map[checks[0]] > 0) ReplaceOnMap(checks[0], newVals[0], map);
        else if(map.ContainsKey(checks[1]) && map[checks[1]] > 0) ReplaceOnMap(checks[1], newVals[1], map);
        else 
        {
            if(map.ContainsKey(currVal)) map[currVal]++;
            else map.Add(currVal, 1);
        }
    }
    
    private void ReplaceOnMap(int oldVal, int potNewVal, Dictionary<int, int> map)
    {
        map[oldVal]--;
        if(map.ContainsKey(potNewVal)) map[potNewVal]++;
        else map.Add(potNewVal, 1);
    }
}