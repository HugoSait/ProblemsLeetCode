# Problem 1480. Running Sum of 1d Array
Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).

Return the running sum of nums.

```C#
public class Solution {
    public int[] RunningSum(int[] nums) {
    }
}
```

# Solución
Para llegar a dicha solución es necesario
- Crear un bucle
    - Iniciaremos la variable en 1 (ya que el indice 0 del array se quedará igual en el resultado)
    - Condición: La variable es menor al tamaño del Array
    - La variable incrementa

    - Dentro del bucle
        - El Array toma el valor de si mismo más el numero anterior de sí mismo

- Mostramos el Array
```C#
public class Solution {
    public int[] RunningSum(int[] nums) {
        for(int i=1;i<nums.Length;i++){
            nums[i] = nums[i] + nums[i-1];
        }
        return nums;
    }
}
```