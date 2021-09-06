public class DetermineIfMatrixCanBeObtainedByRotation_1886{
    public bool FindRotation(int[][] mat, int[][] target) {
        for(int i = 0; i < 4; i++){
            if(CheckSimilarMatrix(mat, target)){
                return true;
            }
            Rotate90(mat);
        }
        return false;
    }
    
    private bool CheckSimilarMatrix(int[][] mat, int[][]target) {
        for(int i = 0; i < mat.Length; i++){
            for(int j = 0; j < mat[i].Length; j++){
                if(mat[i][j] != target[i][j]) return false;
            }
        }
        return true;
    }
    
    private void Rotate90(int[][] mat) {
        transpose(mat);
        reverseColumn(mat);
    }
    
    private void transpose(int[][] mat) {
        for(int i = 0; i < mat.Length; i++) {
            for(int j = i; j < mat[i].Length; j++){
                int temp = mat[j][i];
                mat[j][i] = mat[i][j];
                mat[i][j] = temp;
            }
        }
    }
    private void reverseColumn(int[][] mat) {
        for(int col = 0; col < mat.Length; col++){
            for(int row = 0, bi = mat.Length - 1;  row < bi; row++, bi--){
                int temp = mat[row][col];
                mat[row][col] = mat[bi][col];
                mat[bi][col] = temp;
            }
        }
    }
}