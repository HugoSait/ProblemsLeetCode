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