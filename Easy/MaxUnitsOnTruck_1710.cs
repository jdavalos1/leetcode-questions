public class MaxUnitsOnTruck_1710{
    public int MaximumUnits(int[][] boxTypes, int truckSize) {
        Array.Sort(boxTypes, delegate(int[] m, int[] n) {return n[1] - m[1];});
        
        int totalUnits = 0;
        int i = 0;
        while(truckSize > 0 && i < boxTypes.Length)
        {
            if((truckSize - boxTypes[i][0]) < 0){
                totalUnits += truckSize * boxTypes[i][1];
            } else {
                totalUnits += boxTypes[i][0] * boxTypes[i][1];
            }
            
            truckSize -= boxTypes[i][0];
            i++;
        }
        
        return totalUnits;
    }
}