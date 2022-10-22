# Problem 383. Ransom Note

Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.
Each letter in magazine can only be used once in ransomNote.

```C#
public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        
    }
}
```

# Solución.
- Creamos un vector (Revista) tipo char que obtenga el string (magazine) letra por letra
- Creamos un vector (Letra) tipo char que obtenga el string (ransomNote) letra por letra
- Creamos un entero (notas) que obtenga el valor 0
- Creamos un entero (i) que obtenga el valor 0

- Creamos un ciclo
    Condición
    - Entero (notas) es menor al tamaño del vector (Letra)
        Creamos un if
        Condición
        - Entero (i) es menor al tamaño del vector (Revista)
            Creamos if
            Condición
            - El valor de 'Letras' en la posición de 'notas' es igual al valor de 'Revista' en la posición de 'i'
                - Creamos un entero (index) que obtiene el valor del metodo (IndexOf)*
                    - Sus parametros son: El vector 'Revista' y el valor del vector en la posición de 'i'
                - Revista obtiene el valor del metodo (Revista.Where)* transformado en vector (ToArray())
                    - Se crea una expresión lambda con dos variables (e,a) en la cual el input obtenido es cuando la variable 'a' es diferente a 'index'

                - El entero 'i' obtiene el valor de 0
                - El entero 'notas' aumenta 1 su valor
            - Si no
                - El entero 'i' aumenta 1 su valor
        - Si no
            - Retorna Falso
- Retorna Verdadero


```C#
public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        char[] Revista = magazine.ToCharArray();
        char[] Letra = ransomNote.ToCharArray();
        int notas = 0;
        int i = 0;
        
        while(notas < Letra.Length){
            if (i < Revista.Length){
                if(Letra[notas] == Revista[i]){
                    int index = Array.IndexOf(Revista, Revista[i]);
                    Revista = Revista.Where((e, a) => a != index).ToArray();
                    i=0;
                    notas++;
                }else{
                    i++;
                }
            }else{
                return false;
            }
        }
        return true;
    }
}
```

# Nota
* El metodo IndexOf puede obtener varios parametros, sin embargo en este ejercició toma dos valores y devuelve la posición donde se encuentra dicho valor
    - El primer valor es el arreglo en el cual se hará la busqueda
    - El segundo valor es la cadena u objeto que sera buscado dentro del arreglo

* El metodo Where obtiene como valor una expresión lambda. Las expresiones lambda ayuda a reducir el codigo escrito obteniendo dentro de ellas el valor deseado.