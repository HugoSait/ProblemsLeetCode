public class Solution {
    public void MoveZeroes(int[] nums) {
        // Utilizado cuando la matriz no contiene datos
        if(nums == null || nums.Length == 0){
            return;
        }
        
        // Codigo Base
        int Length = nums.Length;
        for(int i = 0; i < Length ;i++){
            if(nums[i] == 0){
                for(int j = i;j < Length - 1 ;j++){
                    nums[j] = nums[j+1];
                }
                nums[Length - 1] = 0;
                Length--;
                i--;
            }
            
        }
    }
}