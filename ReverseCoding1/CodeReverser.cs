using System;
using System.Collections.Generic;

namespace ReverseCoding1
{
    public class CodeReverser
    {
        private readonly string _string;
        private int[] Ints { get; set; }
        private string CharSequence { get; set; }

        public CodeReverser(string @string)
        {
            _string = @string;
        }

        public void CharToIntArray()
        {
            List<int> intList = new();
            for (int i = 1; i < _string.Length; i += 2)
            {
                char c = _string[i];
                intList.Add((int)Char.GetNumericValue(c));
            }
            Ints = intList.ToArray();
        }

        public void CharsToString()
        {
            string s = "";
            for (int i = 0; i < _string.Length; i += 2)
            {
                char c = _string[i];
                s += c;
            }
            CharSequence = s;
        }

        public string MultiplyChars()
        {
            string s = "";
            for (int i = 0; i < Ints.Length; i++)
            {
                int number = Ints[i];
                char c = CharSequence[i];
                for(int j = 0; j < number; j++)
                {
                    s += c;
                }
            }
            return s;
        }
    }
}
