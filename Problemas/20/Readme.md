# Problem 20. Valid Parentheses
Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

- Open brackets must be closed by the same type of brackets.
- Open brackets must be closed in the correct order.
- Every close bracket has a corresponding open bracket of the same type.

```C#
public class Solution {
    public bool IsValid(string s) {

    }
}
```

# Solution

```C#
public class Solution {
    public bool IsValid(string s) {
        if (s.Length % 2 !=0){
            return false;
        }
        
        Stack<Char> stack= new Stack<Char>();
        
        foreach(char c in s.ToCharArray()){
            if(c== '(' || c== '{' || c== '['){
                stack.Push(c);
            }
            else if(c== ')' && stack.Count != 0 && stack.Peek() == '('){
                stack.Pop();
            }
            else if(c== '}' && stack.Count != 0 && stack.Peek() == '{'){
                stack.Pop();
            }
            else if(c== ']' && stack.Count != 0 && stack.Peek() == '['){
                stack.Pop();
            }
            else{
                return false;
            }
        }
        
        return stack.Count == 0;
    }
}
```