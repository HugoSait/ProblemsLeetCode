# Problem Find Numbers with Even Number of Digits
Given an array nums of integers, return how many of them contain an even number of digits.
```C#
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
```