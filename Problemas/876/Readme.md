# Problem 876. Middle of the Linked List
Given the head of a singly linked list, return the middle node of the linked list.
If there are two middle nodes, return the second middle node.

```C#
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MiddleNode(ListNode head) {
    }
}
```

# Solución
- Creamos una lista de nodos (Count)
- Creamos dos variables de enteros inicializados en cero (i,j)

- La lista obtiene los datos de la lista principal (head)

- Creamos un bucle
    * Si la condición se cumple
    - La condición: Si la lista (Count) es diferente a vacio (null)
        - La lista obtiene el valor del siguiente nodo de la lista
        - La variable (i) aumenta
    - Se repite el ciclo

- La lista obtiene de nuevo los datos de la lista principal (head)

- Creamos un bucle
    * Si la condición se cumple
    - La condición: Si la variable (j) es menor a la division de la variable (i) entre 2
        - La lista obtiene el valor del siguiente nodo de la lista
        - La variable (j) aumenta

- Retornamos la lista de nodos (Count)
```C#
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        ListNode Count;
        int i = 0;
        int j = 0;
        
        Count = head;
        
        while(Count != null){
            Count = Count.next;
            i++;
        }
        
        Count = head;
        while(j<(i/2)){
            Count = Count.next;
            j++;
        }
        
        return Count;
    }
}
```

# Solución 2
Está solución utiliza un solo bucle.
- Se crean dos listas de nodos (Middle, End)
- Se guarda en ambas listas, la lista del nodo principal

- Se crea un bucle
    * Si la condición se cumple
    - La condición: Si nodo (End) es diferente a vacio (null) y
                    Si nodo siguiente (End.next) es diferente a vacio (null)
        - Nodo (Middle) obtiene el dato del Nodo siguiente (Middle.next)
        - Nodo (End) obtiene el dato del Nodo siguiente-siguiente (End.next.next)

    * Repetimos el ciclo

- Retornamos el Nodo (Middle)
```C#
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        ListNode Middle;
        ListNode End;
        
        Middle = head;
        End = head;
        
        while(End != null && End.next != null){
            Middle = Middle.next;
            End = End.next.next;
        }
        
        return Middle;
    }
}
```

# Nota
La solución 2 tiene una condición la cual permite que el nodo (Middle) se posicione siempre en la segunda mitad del nodo principal (head)
Esto sucede porque mientras el nodo (End) se desplaza dos valores, el otro nodo (Middle) se desplaza solo uno. Dejando siempre al nodo (Middle) justo en la mitad de los resultados del nodo principal (head).
*Ejemplo de una lista de nodos con 7 nodos.
    Middle avanza a 2
    End avanza a 3

    Middle avanza a 3
    End avanza a 5

    Middle avanza a 4
    End avanza a 7