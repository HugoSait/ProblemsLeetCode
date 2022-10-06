public class Solution {
    public int[] RunningSum(int[] nums) {
        int[] Totales = new int[nums.Length];
        for(int i=0;i<nums.Length;i++){
            if(i==0){
                Totales[i]= nums[i];
            }else{
                Totales[i]= nums[i] + Totales[i-1];
            }
            
        }
        return Totales;
    }
}