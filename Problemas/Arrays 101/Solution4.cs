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