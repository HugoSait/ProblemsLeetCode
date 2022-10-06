# Problem 1632
You are given an m x n integer grid accounts where accounts[i][j] is the amount of money the i​​​​​​​​​​​th​​​​ customer has in the j​​​​​​​​​​​th​​​​ bank. Return the wealth that the richest customer has.

A customer's wealth is the amount of money they have in all their bank accounts. The richest customer is the customer that has the maximum wealth.
````C#
public class Solution {
    public int MaximumWealth(int[][] accounts) {

    }
}
````

Explicación del Codigo
- Se crea una variable
- Se crea un Vector con el tamaño de filas del Vector Principal
- Se crea un bucle 
````C#
public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int TheBestRich = 0; 
        int [] Customer = new int[accounts.Length]; 
        
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
````