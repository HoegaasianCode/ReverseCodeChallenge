using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseCoding1
{
    public class CodeReverser
    {
        private readonly string _string;
        private int[] Ints { get; set; }
        private string Chars { get; set; }

        public CodeReverser(string @string)
        {
            _string = @string;
        }

        public void CharToIntArray()
        {
            List<int> intList = new();
            for (int i = 1; i < _string.Length; i+=2)
            {
                char c = _string[i];
                intList.Add((int)Char.GetNumericValue(c));
            }
            Ints = intList.ToArray();
        }

        public void CharToNewString() 
        {
            StringBuilder sb = new();
            for(int i = 0; i < _string.Length; i+=2)
            {
                char c = _string[i];
                sb.Append(c);
            }
            Chars = sb.ToString();
        }

        public string MultiplyCharsByInts()
        {
            StringBuilder sb = new();
            for(int i = 0; i < Ints.Length; i++)
            {
                int integer = Ints[i];
                char c = Chars[i];
                sb.Append(c, integer);
            }
            return sb.ToString();
        }
    }
}
