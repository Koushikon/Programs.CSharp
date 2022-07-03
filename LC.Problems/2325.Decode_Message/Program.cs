using System;
using System.Collections.Generic;

public class Solution
{
    public string DecodeMessage(string key, string message)
    {
        key = key.Replace(" ", String.Empty);
        var isHave = new Dictionary<char, char>();
        string alphabet = "abcdefghijklmnopqrstuvwxyz";

        int val = 0;
        for (int i = 0; i < key.Length; i++)
        {
            if (!isHave.ContainsKey(key[i]))
            {
                isHave[key[i]] = Convert.ToChar(alphabet[val++]);
            }
        }

        // foreach (KeyValuePair<char, char> author in isHave)
        // {
        //     Console.WriteLine("Key: {0}, Value: {1}", author.Key, author.Value);
        // }

        char[] e_msg = new char[message.Length];
        for (int i = 0; i < message.Length; i++)
        {
            if (message[i] == ' ')
                e_msg[i] = ' ';
            else
            {
                e_msg[i] = isHave[message[i]];
            }
        }
        return new String(e_msg);
    }
}

namespace Decode_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution serv = new Solution();
            string res = serv.DecodeMessage("eljuxhpwnyrdgtqkviszcfmabo", "zwx hnfx lqantp mnoeius ycgk vcnjrdb");

            Console.WriteLine(res);
        }
    }
}
