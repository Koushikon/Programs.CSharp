using System;
using System.Text;

static string LongestCommonPrefix(string[] strs)
{
    string word = strs[0];
    if (strs.Length == 1)
        return word;

    int smaller = 0;
    StringBuilder last_WORD = new StringBuilder();

    for (int i = 1; i < strs.Length; i++)
    {
        smaller = (word.Length < strs[i].Length) ? word.Length : strs[i].Length;
        // Console.WriteLine("{0} {1} {2}", word.Length, strs[i].Length, smaller);

        last_WORD.Clear();
        for (int j = 0; j < smaller; j++)
        {
            if (word[j] != strs[i][j])
                break;
            last_WORD.Append(word[j]);
        }
        word = last_WORD.ToString();
    }
    return word;
}

string[] CmnAry = new string[] { "cir", "car" };

string res = LongestCommonPrefix(CmnAry);
Console.WriteLine($"Common Prefix Characters are: {res}");