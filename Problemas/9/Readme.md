# Problem 9. Palindrome Number
Given an integer x, return true if x is palindrome integer.
An integer is a palindrome when it reads the same backward as forward.

```C#
public class Solution {
    public bool IsPalindrome(int x) {

    }
}
```

# Solution
```C#
public class Solution {
    public bool IsPalindrome(int x) {
        string number = x.ToString();
        char[] charArray = number.ToCharArray();  
        Array.Reverse(charArray);
        string reversenumber = new string(charArray);
        
        return string.Equals(number,reversenumber);
    }
}
```