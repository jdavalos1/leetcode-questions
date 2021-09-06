using System;
using System.Collections.Generic;

public class ValidParenthesis_20{
    public bool IsValid(string s) {
        if(s.Length % 2 == 1) return false;
        
        Stack stack = new Stack();
        var cList = new List<char>();
        cList.AddRange(s);
        
        Recurse(stack, cList);
        
        return stack.Count == 0;
    }
    
    private void Recurse(Stack s, List<char> parens)
    {
        if(parens.Count == 0) return;
        
        switch(parens[0])
        {
            case '(':
            case '{':
            case '[':
                s.Push(parens[0]);
                break;
            case ')':
                if(s.Count == 0 || Convert.ToChar(s.Peek()) != '(') {
                    s.Push('f');
                    return;
                }
                s.Pop();
                break;
            case '}':
                if(s.Count == 0 || Convert.ToChar(s.Peek()) != '{') {
                    s.Push('f');
                    return;
                }
                s.Pop();
                break;
            case ']':
                if(s.Count == 0 || Convert.ToChar(s.Peek()) != '['){
                    s.Push('f');
                    return;
                }
                s.Pop();
                break;
        }
        
        parens.RemoveAt(0);
        Recurse(s, parens);
    }
}