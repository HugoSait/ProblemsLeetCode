# Problem. Max Consecutive Ones
Given a binary array nums, return the maximum number of consecutive 1's in the array.
```C#
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
```

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