// Solution:
// Loop through string array and check if character is open or close paranthesis.
// On open bracket, increase depth counter, make max depth check, and push bracket to stack.
// On close bracket, decrease depth counter, pop bracket from stack.
// Return maxDepth.

public class Solution {
    public int MaxDepth(string s) {
        Stack myStack = new Stack();
        int depth = 0;
        int maxDepth = 0;
        
        for(int i = 0; i < s.Length; i++) {
            char ch = s[i];
            if( ch == '(' ) {
                myStack.Push(ch);
                depth++;
                if( depth > maxDepth )
                    maxDepth = depth;
            }
            else if(myStack.Count > 0 && ch == ')' ){
                if( myStack.Peek().Equals('(') ) {
                    myStack.Pop();
                    depth--;
                }
            }
        }
        return maxDepth;
    }
}