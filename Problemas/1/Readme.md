# Problem 1. Two Sum
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
You can return the answer in any order.
```C#
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
    }
}
```

# Solution

```C#
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
```