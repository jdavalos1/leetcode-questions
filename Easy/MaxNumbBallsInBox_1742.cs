public class MaxNumbBallsInBox_1742{
    public int CountBalls(int lowLimit, int highLimit) {
        var map =  new Dictionary<int, int>();
        var max = -1;        
        for(var i = lowLimit; i <= highLimit; i++)
        {
            var temp = i;
            var total = 0;
            
            while(temp != 0)
            {
                
                total += temp % 10;
                temp /= 10;
            }
            
            if(map.ContainsKey(total)) map[total]++;
            else map.Add(total, 1);
        }
        
        foreach (var kvp in map)
        {
            if(kvp.Value > max) max = kvp.Value;
        }
        
        return max;
    }
}