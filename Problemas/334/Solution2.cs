// Optimizado

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