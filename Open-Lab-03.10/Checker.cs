using System;

namespace Open_Lab_03._10
{
    public class Checker
    {
        public int GetNumberOfCharsInString(char letter, string str)
        {
            int letter_count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (letter == str[i])
                {
                    letter_count++;
                }
            }
            return letter_count;
        }
    }
}