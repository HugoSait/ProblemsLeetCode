public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int [] arr = new int [nums.Length];
        int numarr = 0;
        Array.Sort(nums);
        
        arr[numarr] = nums[0];
        for(int i = 1; i < nums.Length ; i++){
            if (arr[numarr] != nums[i]){
                numarr++;
                arr[numarr] = nums[i];
            }
        }
        numarr++;
        
        for(int i = 0; i < numarr ; i++){
            nums[i] = arr[i];
        }
        
        return numarr;
        
    }
}