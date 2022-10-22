# Problem 283. Move Zeroes
Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Note that you must do this in-place without making a copy of the array.
```C#
public class Solution {
    public void MoveZeroes(int[] nums) {

    }
}
```

# Solution
Cuando las soluciones no contengan datos, hay que retornar de inmediato, para ahorrar tiempos de ejecución

- Inicializamos una variable entera (Length) que obtiene el valor del tamaño del vector (nums)
- Creamos un ciclo
    Condición
    - Si la variable (i) es menor a la variable Length

        - Inicializamos una condición
            Condición
            - Si el valor dentro del vector es igual a 0
                - Creamos un ciclo
                    Condición
                    - Si la variable (j) es menor a la variable Length menos 1
                    - El vector en la posición actual (j) obtiene el valor de el vector una posición adelante (j+1)
                
                - El vector con la posición de la variable (Length) menos 1 obtiene el valor de 0
                - La variable Length disminuye
                - La variable del primer ciclo disminuye (Con el funcionamiento de volver a checar si otro 0 entro en la posición actual)
```C#
public class Solution {
    public void MoveZeroes(int[] nums) {
        // Utilizado cuando la matriz no contiene datos
        if(nums == null || nums.Length == 0){
            return;
        }
        
        // Codigo Base
        int Length = nums.Length;
        for(int i = 0; i < Length ;i++){
            if(nums[i] == 0){
                for(int j = i;j < Length - 1 ;j++){
                    nums[j] = nums[j+1];
                }
                nums[Length - 1] = 0;
                Length--;
                i--;
            }
            
        }
    }
}
```