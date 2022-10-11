public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] Valores = new int[2];
        
        for (int i=0;i<nums.Length;i++){
            for(int j=i+1;j<nums.Length;j++){
                if((nums[i]+nums[j]) == target){
                    Valores[0] = i;
                    Valores[1] = j;
                }
            }
        }
        return Valores;
    }
}