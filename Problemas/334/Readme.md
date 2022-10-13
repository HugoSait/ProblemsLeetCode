# Problem 334. Increasing Triplet Subsequence
Given an integer array , return if there exists a triple of indices such that and .
If no such indices exists, return .numstrue(i, j, k)i < j < knums[i] < nums[j] < nums[k]false

```C#
public class Solution {    
    public bool IncreasingTriplet(int[] nums)
    {
        
    }
       
}
```

# Solution
```C#
public class Solution {
    
    public bool IncreasingTriplet(int[] nums)
    {
        int i = int.MaxValue;
        int j = int.MaxValue;

        for (int k = 0; k < nums.Length; k++)
        {
            if (nums[k] <= i)
            {
                i = nums[k];
            }
            else if(nums[k] <= j)
            {
                j = nums[k];    
            }
            else
            {
                return true;
            }
        }
        return false;
    }
       
}
```