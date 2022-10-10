/*Solución Imparcial
 * La solución funciona con palabras que solo utilizan una letra
 * La solución no borra de la revista, las letras ya encontradas
*/
public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        char[] Revista = magazine.ToCharArray();
        char[] Letra = ransomNote.ToCharArray();
        int notas = 0;
        int i = 0;
            
        
        while(notas < Letra.Length){
            if (i < Revista.Length){
                if(Letra[notas] == Revista[i]){
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