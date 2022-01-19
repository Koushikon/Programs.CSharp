using System;


static bool IsPalindrome(int x) // 12345
{
    string number = x.ToString();
    int size = (number.Length / 2);

    for (int i = 0; i < size; i++)
    {
        int opposite = number.Length - i - 1;
        if (number[i] != number[opposite])
            return false;
    }

    // Console.WriteLine(number);
    return true;
}

int num = 11211;
bool status = IsPalindrome(num);

Console.WriteLine((status) ? $"{num} is Palindrome" : $"{num} is Not a Palindrome");