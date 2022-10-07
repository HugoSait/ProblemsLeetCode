# Problem 2236. Root Equals Sum of Children
You are given the root of a binary tree that consists of exactly 3 nodes: the root, its left child, and its right child.
Return true if the value of the root is equal to the sum of the values of its two children, or false otherwise.

```C#
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool CheckTree(TreeNode root) {
    }
}
```

# Solución
- Creamos una condición
    * La condición: Si el valor de la variable (val) del arbol (root) es igual 
                    a la variable (val) del lado izquierdo (left) del arbol (root) más
                    a la variable (val) del lado derecho (right) del arbol (root)
    - Si la condición se cumple
        - Se retorna verdadero
    
    - Si la condición no se cumple
        - Se retorna falso

# Nota: El problema a te define como se manejara los nodos del arbol binario, por ello las variables predefinidas

```C#
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool CheckTree(TreeNode root) {
        if(root.val == root.left.val + root.right.val)
        {
            return true;
        }
        else{
            return false;
        };
        
    }
}
```