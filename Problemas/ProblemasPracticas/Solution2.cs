public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int num1 = 0;
        int result = 0;
        
        for (int i= 0;i<nums.Length;i++){
            if(nums[i]==1){
                num1+=1;
            }
            else{
                if(result<=num1){
                    result = num1;
                    num1 = 0;
                }
                else{
                    num1 = 0;
                }
            }
        }
        if(result<=num1){
            result = num1;
        }
        
        return result;
    }
}