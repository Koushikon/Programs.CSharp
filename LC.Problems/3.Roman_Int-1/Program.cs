using System;


static int RomanToInt(string s)
{
    int[] numbers = new int[] { 1, 5, 10, 50, 100, 500, 1000 };
    int sum = 0;

    for (int c = 0; c < s.Length; c++)
    {
        // Console.WriteLine(s[c]);
        switch (s[c])
        {
            case 'I':
                {
                    sum += numbers[0];
                    // Console.WriteLine(numbers[0]);
                    if (c < s.Length - 1)
                    {
                        if (s[c + 1] == 'V')
                        {
                            sum += Math.Abs(numbers[1] - numbers[0] - numbers[0]);
                            c++;
                        }
                        else if (s[c + 1] == 'X')
                        {
                            sum += Math.Abs(numbers[2] - numbers[0] - numbers[0]);
                            c++;
                        }
                    }
                }
                break;
            case 'V':
                {
                    sum += numbers[1];
                }
                break;
            case 'X':
                {
                    sum += numbers[2];
                    if (c < s.Length - 1)
                    {
                        if (s[c + 1] == 'L')
                        {
                            sum += Math.Abs(numbers[3] - numbers[2] - numbers[2]);
                            c++;
                        }
                        else if (s[c + 1] == 'C')
                        {
                            sum += Math.Abs(numbers[4] - numbers[2] - numbers[2]);
                            c++;
                        }
                    }
                }
                break;
            case 'L':
                {
                    sum += numbers[3];
                }
                break;
            case 'C':
                {
                    sum += numbers[4];
                    if (c < s.Length - 1)
                    {
                        if (s[c + 1] == 'D')
                        {
                            sum += Math.Abs(numbers[5] - numbers[4] - numbers[4]);
                            c++;
                        }
                        else if (s[c + 1] == 'M')
                        {
                            sum += Math.Abs(numbers[6] - numbers[4] - numbers[4]);
                            c++;
                        }
                    }
                }
                break;
            case 'D':
                {
                    sum += numbers[5];
                }
                break;
            case 'M':
                {
                    sum += numbers[6];
                }
                break;
            default:
                Console.WriteLine("Couldn't Understand.");
                break;
        }
    }
    return sum;
}

for (int i = 0; i < 10; i++)
{
    string[] RomanNums = new string[] { "MIX", "MIV", "DIV", "DIX", "DX", "MCMXCIV", "MMX", "XX", "D", "LVIII" };
    int res = RomanToInt(RomanNums[i]);
    Console.WriteLine($"The number is: {res}");
}