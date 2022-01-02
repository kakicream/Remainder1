using System;
using System.Collections.Generic;

// 프로그래머스 코딩테스트 연습
// 나머지가 1이 되는 수 찾기  

namespace Remainder1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int Solution(int n)
            {                
                List<int> ansList = new List<int>();
                for (int i = 1; i < n; i++)
                {
                    if (n%i == 1)
                    {
                        ansList.Add(i);
                    }
                }                
                return ansList[0];
            }

            // Test
            Console.WriteLine(Solution(10));
            Console.WriteLine(Solution(12));
        }
    }
}
