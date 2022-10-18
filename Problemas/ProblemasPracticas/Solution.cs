public class Solution {
    public int FindNumbers(int[] nums) {
        int result = 0;
        
        for(int i = 0;i<nums.Length;i++){
            int count = 0;
            
            while(nums[i]!=0){
                nums[i] = nums[i]/10;
                count++;
            }
            
            if(count % 2 == 0){
                result++;
            }
            
        }
        
        return result;
    }
}