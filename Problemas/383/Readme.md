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