public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int TheBestRich = 0;
        int [] Customer = new int[accounts.GetLength(0)];
        for(int i=0;i<accounts.Length;i++){
            
            for(int j=0;j<accounts[i].Length;j++){
                Customer[i] += accounts[i][j];
            }
            
            if(Customer[i]>TheBestRich){
                TheBestRich = Customer[i];
            }
        }
        return TheBestRich;
    }
}