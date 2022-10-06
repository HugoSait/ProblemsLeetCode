public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int TheBestRich = 0;
        int [] Customer = new int[accounts.GetLength(0)];
        for(int i=0;i<accounts.GetLength(0);i++){
            for(int j=0;j<accounts.GetLength(1);j++){
                Customer[i] += accounts[i][j];
            }
        }
        
        for(int i=0;i<Customer.Length;i++){
            if(Customer[i]>TheBestRich){
                TheBestRich = Customer[i];
            }
        }
        return TheBestRich;
    }
}