public class Solution {
    public int[] SortedSquares(int[] nums) {
        int [] array = new int[nums.Length];
        
        for(int i = 0; i<nums.Length ;i++){
            if(nums[i] == 0){
                array[i] = nums[i];
            }
            else if(nums[i] < 0){
                nums[i] = nums[i]*(-1);
                array[i] = nums[i] * nums[i];
            }
            else{
                array[i] = nums[i] * nums[i];
            }
        }
        
        Array.Sort(array);
        
        return array;
            
    }
}