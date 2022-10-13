public class Solution {
    public bool IsPalindrome(int x) {
        string number = x.ToString();
        char[] charArray = number.ToCharArray();  
        Array.Reverse(charArray);
        string reversenumber = new string(charArray);
        
        return string.Equals(number,reversenumber);
    }
}