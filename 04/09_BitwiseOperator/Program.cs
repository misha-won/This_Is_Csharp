// 4.9.2 비트 논리 연산자
// 비트 논리 연산은 각 비트의 1을 참, 0을 거짓으로 간주한다.

namespace _09_BitwiseOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 9;  // 0000 0000 0000 1001
            int b = 10; // 0000 0000 0000 1010

            Console.WriteLine($"{a} & {b} : {a & b}");  // 0000 0000 0000 1000
            Console.WriteLine($"{a} | {b} : {a | b}");  // 0000 0000 0000 1011
            Console.WriteLine($"{a} ^ {b} : {a ^ b}");  // 0000 0000 0000 0011

            int c = 255;
            Console.WriteLine("~{0}(0x{0:X8}) : {1}(0x{1:X8})", c, ~c);
            // 0000 0000 1111 1111
            // 1111 1111 0000 0000

            // 9 & 10 : 8
            // 9 | 10 : 11
            // 9 ^ 10 : 3
            // ~255(0x000000FF) : -256(0xFFFFFF00)
        }
    }
}
