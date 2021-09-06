public class HammingDistance_461{
    public int HammingDistance(int x, int y) {
        int dist = 0;
        
        for(int val = x ^ y; val > 0; ++dist)
        {
            val = val & (val - 1);
        }
        
        return dist;
    }
}