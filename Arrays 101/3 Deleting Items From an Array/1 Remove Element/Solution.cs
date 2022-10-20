public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int [] Array = new int[nums.Length];
        int numArray = 0;
        for(int i = 0; i < nums.Length ; i++){
            if(nums[i] != val){
                Array[numArray] = nums[i];
                numArray++;
            }
        }
        
        for(int i = 0; i < numArray ; i++){
            nums[i] = Array[i];
        }
        

        
        
        return numArray;
    }
}