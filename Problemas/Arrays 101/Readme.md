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

# Problem Duplicate Zeros
Given a fixed-length integer array arr, duplicate each occurrence of zero, shifting the remaining elements to the right.
- Note: that elements beyond the length of the original array are not written. Do the above modifications to the input array in place and do not return anything.
```C#
public class Solution {
    public void DuplicateZeros(int[] arr) {
        for(int i = 0; i < arr.Length ;i++){
            if(arr[i] == 0){
                for(int j = arr.Length-2; j >= i ;j--){
                    arr[j+1] = arr[j];
                }
                i++;
            }
            
        }
    }
}
```