using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAlgorithms
{
    public class Leetcode13
    {
        public static int RomanToInt(string s)
        {
            int num = GetInt(s[0]); ;
            if (s.Length == 1) return num;
            for (int i = 1; i < s.Length; i++)
            {
                var cur = GetInt(s[i]);
                var prev = GetInt(s[i - 1]);
                switch (cur <= prev)
                {
                    case true: num += cur; break;
                    case false: num += (cur - 2 * prev); break;
                }
            }
            return num;


            static int GetInt(char c)
            {
                switch (c)
                {
                    case 'I': return 1;
                    case 'V': return 5;
                    case 'X': return 10;
                    case 'L': return 50;
                    case 'C': return 100;
                    case 'D': return 500;
                    case 'M': return 1000;
                    default: return 0;
                }
            }
        }
    }
}
