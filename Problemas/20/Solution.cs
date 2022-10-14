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