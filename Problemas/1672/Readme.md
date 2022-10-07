# Problem 1632. Richest Customer Wealth
You are given an m x n integer grid accounts where accounts[i][j] is the amount of money the i​​​​​​​​​​​th​​​​ customer has in the j​​​​​​​​​​​th​​​​ bank. Return the wealth that the richest customer has.

A customer's wealth is the amount of money they have in all their bank accounts. The richest customer is the customer that has the maximum wealth.
````C#
public class Solution {
    public int MaximumWealth(int[][] accounts) {

    }
}
````

# Solución
Explicación del Codigo
- Se crea una variable "TheBestRich"
- Se crea un Vector "Customer" con el tamaño de filas del Vector principal
- Se crea un bucle 
    * Se define una variable que inicie en 0
    * La condición es hasta el tamaño del Vector principal
    * La variable aumenta
    
    - Dentro del bucle, creamo otro bucle
        * Se define una variable que inicie en 0
        * La condición es hasta el tamaño del Vector "i" dentro del Vector principal
        * La variable aumenta

        - Dentro del bucle
            - El Vector "Customer" guarda el valor de si mismo más el valor del Vector "i", esto hasta finalizar la iteración del bucle

        - Se crea una condición
            * Se le define que el Vector "Customer" es mayor a la variable "TheBestRich"
            
            - Si esta condición se cumple, la variable guarda el valor del vector
        

- Se retorna el valor de la variable "TheBestRich"


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