public class Solution {
    public bool CheckIfPangram(string sentence) {
        //Si la cadena no es mayor a todo el alfabeto, es falso
        if(sentence.Length < 26){
            return false;
        }
        
        
        int[] Alfabeto = new int[26];
        
        foreach(var ab in sentence){
            Alfabeto[ab - 'a']++;
        }
        
        foreach(var i in Alfabeto){
            if (i == 0){
                return false;
            }
        }
        
        return true;
    }
}