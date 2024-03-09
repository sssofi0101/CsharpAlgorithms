using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAlgorithms
{
    public class Leetcode9
    {
            public static bool IsPalindrome(int x)
            {
                if (x < 0) return false;
                if (x < 10) return true;
                var num = Convert.ToString(x);
                for (int i = 0; i <= num.Length / 2; i++)
                {
                    if (num[i] == num[num.Length - i - 1])
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    
}
