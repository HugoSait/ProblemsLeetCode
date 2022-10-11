public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        
        for(int i=0;(i+2)<nums.Length;i++){
            for(int j=i+1;j<nums.Length;j++){
                for(int k=j+1;k<nums.Length;k++){
                    if(nums[i]<nums[j] && nums[j]<nums[k]){
                        return true;
                    }
                }
            }
        }
        return false;
    }
}