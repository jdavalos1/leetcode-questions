public class RunningSumOf1dArray_1480{
    public int[] RunningSum(int[] nums) {
        var runningSum = new int[nums.Length];
        runningSum[0] = nums[0];
        for(var i = 1; i < nums.Length; i++){
            runningSum[i] = nums[i] + runningSum[i-1];
        }
        return runningSum;
    }
}