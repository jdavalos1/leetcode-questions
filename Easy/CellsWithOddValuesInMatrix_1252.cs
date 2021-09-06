public class CellsWithOddValuesInMatrix_1252{
    public int OddCells(int m, int n, int[][] indices) {
        var rows = new int[m];
        var cols = new int[n];
        int totalOdds = 0;
        
        foreach(var pair in indices)
        {
            rows[pair[0]]++;
            cols[pair[1]]++;
        }
        
        foreach(var row in rows)
        {
            foreach(var col in cols)
            {
                if((row + col) % 2 != 0) totalOdds++;
            }
        }
        
        return totalOdds;
    }
}