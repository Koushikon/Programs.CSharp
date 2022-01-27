using System;
using System.Collections.Generic;

/**
 * * LC Valid Parentheses Check
 * * Like "({[]})", "()[]{}", "{()}", "[]" ... True
 * * Like "]", "(]", "({]})", "(]])" ... False
 */

static bool IsValid(string s)
{
    var direct = new Dictionary<char, char>
    {
        ['('] = ')',
        ['{'] = '}',
        ['['] = ']'
    };

    if (s.Length == 0 || (s.Length % 2 != 0) || s[0] == ')' || s[0] == '}' || s[0] == ']')
        return false;

    var bracket = new List<char>();
    for (int i = 0; i < s.Length; i++)
    {
        if (direct.ContainsKey(s[i]))
        {
            bracket.Add(direct[s[i]]);
            continue;
        }

        if (bracket.Count > 0)
        {
            if (s[i] == bracket[bracket.Count - 1])
                bracket.RemoveAt(bracket.Count - 1);
            else
                return false;
        }
        else if (bracket.Count == 0 && s[i] == ')' || s[i] == '}' || s[i] == ']')
            return false;
    }

    return (bracket.Count == 0) ? true : false;
}

string[] arr = new string[] {
    "({[]})", "()[]{}", "{()}", "[]", "]", "(]", "({]})", "(]])", "}[", "(){}}{"
};

foreach (string word in arr)
{
    bool res = IsValid(word);
    Console.WriteLine($"{word} - Valid Parentheses is: {res}");
}