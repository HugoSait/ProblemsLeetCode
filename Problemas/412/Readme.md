# Problem 412. Fizz Buzz
Given an integer n, return a string array answer (1-indexed) where:
    - answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
    - answer[i] == "Fizz" if i is divisible by 3.
    - answer[i] == "Buzz" if i is divisible by 5.
    - answer[i] == i (as a string) if none of the above conditions are true.

```C#
public class Solution {
    public IList<string> FizzBuzz(int n) {
    }
}
```

# Solución
Los pasos a seguir para resolver son los siguiente:
    - Crear una lista la cual tenga como tamaño inicial la variable del problema (n)
    - Crear un bucle
        * Inicializar la variable en 1 (la variable sera utilizada dentro del bucle para el problema, por lo cual es necesario que inicie en 1)
        * La condición es que la variable sea menor-igual a la variable del problema (n)
        * La variable incrementa
        
        - Dentro del bucle.
            - Se crea una condición
                * Deben cumplirse ambas condiciones
                - La variable (i) mood 3 es igual a 0 y La variable (i) mood 5 es igual a 0

                * Si la condición se cumple
                    - Se agrega a la lista "FizzBuzz"

            - Se crea una segunda condición en caso de no cumplirse la anterior
                - La variable (i) mood 5 es igual a 0

                * Si la condición se cumple
                    - Se agrega a la lista "Buzz"
            
            - Se crea una tercera condición en caso de no cumplirse la anterior
                - La variable (i) mood 3 es igual a 0

                * Si la condición se cumple
                    - Se agrega a la lista "Fizz"

            - En caso de que ninguna de las demas condiciones se cumpla
                - Se agrega en modo de cadena el numero de la iteración actual (i)

    - Retornamos la lista
```C#
public class Solution {
    public IList<string> FizzBuzz(int n) {
        List<string> answer = new List<string>(n);
        
        for(int i = 1;i<=n;i++){
            if(i%3 == 0 && i%5 == 0){
                answer.Add("FizzBuzz");
            }
            else if(i%5 == 0){
                answer.Add("Buzz");
            }
            else if (i%3 == 0){
                answer.Add("Fizz");
            }
            else{
                answer.Add(Convert.ToString(i));
            }    
        }
        
        return answer;
    }
}
```