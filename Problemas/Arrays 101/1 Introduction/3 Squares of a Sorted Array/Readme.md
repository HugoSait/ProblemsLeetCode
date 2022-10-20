# Problem Squares of a Sorted Array
Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.
```C#
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
```