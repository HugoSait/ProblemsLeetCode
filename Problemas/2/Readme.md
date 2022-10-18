# Problem 2. Add Two Numbers
You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
You may assume the two numbers do not contain any leading zero, except the number 0 itself.
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {

    }
}
```

# Solution
El problema te ofrece la idea de como esta creada la clase ListNode.

- Se crea un Nodo con valor inicial en 0 (resultado).
- Se crea un Nodo con valor del Nodo anterior (head).
- se crea una variable tipo entero con valor 0(carry).

- Se crea un bucle (while)
    Condición
    - Si la l1 es diferente a vacio (null) o l2 es diferente a vacio, se entra al ciclo.

        Dentro del bucle
        - se crea una variable tipo entero con el valor de la variable anterior (sum).

        Condición
        - Si l1 es diferente a vacio, continua.
            - el entero (sum) obtiene el valor de si mismo más el valor de l1.
        
        Condición
        - Si l2 es diferente a vacio, continua.
            - el entero (sum) obtiene el valor de si mismo más el valor de l2.

        (Esté calculo nos permite saber si un resultado es mayor o igula a 10, esto nos ayuda a obtener el decimal y solo insertar la unidad más adelante)
        Condición
        - el entero (carry) obtiene el valor del entero (sum) entre 10.
        - el entero (sum) obtiene el residuo de su mismo valor y 10.
        Si no
        - el entero (carry) obtiene el valor de 0.

        - El Nodo (resultado) siguiente obtiene el valor del entero (sum) en el nuevo Nodo.
        - El Nodo obtiene el valor del siguiente Nodo.
    Termina el bucle

    Condición
    - Si el entero (carry) es mayor a 0.
        - El Nodo (resultado) siguiente obtiene el valor del entero (carry) en el nuevo Nodo.
    
    - Retornamos el valor del Nodo (head) que obtiene el valor del Nodo siguiente.


        
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode resultado = new ListNode(0);
        ListNode head = resultado;
        int carry = 0;

        while(l1 != null || l2 != null){
            int sum = carry;

            if(l1 != null){
                sum +=l1.val; // sum = sum + l1.val;
                l1 = l1.next;
            }

            if(l2 != null){
                sum += l2.val;
                l2 = l2.next;
            }

            //Calculo por si el resultado obtiene más de 10 y debemos pasar el decimal al siguiente número
            // Si el valor no es mayor a 10, no es necesario pasar algún decimal al siguiente número
            if(sum >= 10){
                carry = sum / 10;
                sum = sum % 10;
            }
            else{ 
                carry = 0;
            }

            resultado.next = new ListNode(sum);
            resultado = resultado.next;
        }

        if(carry > 0){
            resultado.next = new ListNode(carry);
        }

        return head = head.next;
    }
    
}
```