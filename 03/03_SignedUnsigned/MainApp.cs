using System;

namespace _03_SignedUnsigned
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            byte  a = 255;          // byte 형식 255는 1111 1111
            sbyte b = (sbyte)a;     // (sbyte)는 변수를 sbyte 형식으로 변환하는 연산자

            Console.WriteLine(a);   // 255
            Console.WriteLine(b);   // -1

            // 2의 보수법 (예: -1)
            // 1. 먼저 수 부분 비트를 채운다.   (0000 0001)
            // 2. 전체 비트를 반전시킨다.       (1111 1110)
            // 3. 반전된 비트에 1을 더한다.     (1111 1111)
        }
    }
}
