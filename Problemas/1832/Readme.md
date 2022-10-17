# Problems 1832. Check if the Sentence Is Pangram
A pangram is a sentence where every letter of the English alphabet appears at least once.
Given a string sentence containing only lowercase English letters, return true if sentence is a pangram, or false otherwise.

```C#
public class Solution {
    public bool CheckIfPangram(string sentence) {

    }
}
```

# Solution
```C#
public class Solution {
    public bool CheckIfPangram(string sentence) {

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
```