# Problem 1342. Number of Steps to Reduce a Number to Zero
Given an integer num, return the number of steps to reduce it to zero.
In one step, if the current number is even, you have to divide it by 2, otherwise, you have to subtract 1 from it.

```C#
public class Solution {
    public int NumberOfSteps(int num) {
}
```

# Solución
- Inicializamos una variable para iterar (i)
- Creamos un bucle con while
    * La condición: La variable del problema (num) es diferente a 0 
    - Si la condición se cumple
        - Creamos una condición
            * La condición: La variable (num) mood 2 es igual a 0
            - Si la condición se cumple
                - La variable (num) guarda el valor de si misma entre 2
            - Si la condición no se cumple
                - La variable (num) guarda el valor de si misma menos 1
            
            - Aumentamos la variable para iterar (i)
    # Nota: El bucle se repite hasta lograr que num llegue a 0

- Retornamos la variable de iteración (i)

```C#
public class Solution {
    public int NumberOfSteps(int num) {
        int i = 0;
        
        while(num!=0){
            if(num%2 == 0){
                num = num/2;
            }
            else{
                num = num - 1;
            }
            i++;
        }
        
        return i;
    }
}
```