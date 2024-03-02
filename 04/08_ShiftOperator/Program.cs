// 4.9 비트 연산자
// 비트 수준에서 데이터를 가공해야 하는 경우에 사용하는 연산자이다.

// <<(왼쪽 시프트 연산자)
// - 첫 번째 피연산자의 비트를 두 번째 피연산자의 수만큼 왼쪽으로 이동시킨다.
// - 첫 번째 피연산자는 int, uint, long, ulong이며 두 번째 피연산자는 int 형식만 지원한다.

// >>(오른쪽 시프트 연산자)
// - 첫 번째 피연산자의 비트를 두 번째 피연산자의 수만큼 오른쪽으로 이동시킨다.
// - 첫 번째 피연산자는 int, uint, long, ulong이며 두 번째 피연산자는 int 형식만 지원한다.

// &(논리곱(AND) 연산자)
// - 두 피연산자의 비트 논리곱을 수행한다.
// - 정수 계열 형식과 bool 형식에 대해 사용할 수 있다.

// |(논리합(OR) 연산자)
// - 두 피연산자의 비트 논리합을 수행한다.
// - 정수 계열 형식과 bool 형식에 대해 사용할 수 있다.

// ^(배타적 논리합(XOR) 연산자)
// - 두 피연산자의 비트 배타적 논리합을 수행한다.
// - 정수 계열 형식과 bool 형식에 대해 사용할 수 있다.

// ~(보수(NOT) 연산자)
// - 피연산자의 비트를 0은 1로, 1은 0으로 반전시킨다.
// - 단항 연산자이다.
// - int, uint, long, ulong에 대해 사용할 수 있다.

// 4.9.1 시프트 연산자(Shift Operator)
// 비트 이동(Shift)의 규칙 : 밀려 나온 비트는 버리고, 비어 있는 비트에는 0을 채워 넣는다.

namespace _08_ShiftOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing <<...");

            int a = 1;
            Console.WriteLine("a      : {0:D5} (0x{0:X8})", a);
            Console.WriteLine("a << 1 : {0:D5} (0x{0:X8})", a << 1);
            Console.WriteLine("a << 2 : {0:D5} (0x{0:X8})", a << 2);
            Console.WriteLine("a << 5 : {0:D5} (0x{0:X8})", a << 5);

            Console.WriteLine("\nTesting >>...");

            int b = 255;
            Console.WriteLine("b      : {0:D5} (0x{0:X8})", b);
            Console.WriteLine("b >> 1 : {0:D5} (0x{0:X8})", b >> 1);
            Console.WriteLine("b >> 2 : {0:D5} (0x{0:X8})", b >> 2);
            Console.WriteLine("b >> 5 : {0:D5} (0x{0:X8})", b >> 5);

            Console.WriteLine("\nTesting >> 2...");

            int c = -255;
            Console.WriteLine("c      : {0:D5} (0x{0:X8})", c);
            Console.WriteLine("c >> 1 : {0:D5} (0x{0:X8})", c >> 1);
            Console.WriteLine("c >> 2 : {0:D5} (0x{0:X8})", c >> 2);
            Console.WriteLine("c >> 5 : {0:D5} (0x{0:X8})", c >> 5);

            // Testing <<...
            // a : 00001 (0x00000001)
            // a << 1 : 00002 (0x00000002)
            // a << 2 : 00004 (0x00000004)
            // a << 5 : 00032 (0x00000020)

            // Testing >>...
            // b : 00255 (0x000000FF)
            // b >> 1 : 00127 (0x0000007F)
            // b >> 2 : 00063 (0x0000003F)
            // b >> 5 : 00007 (0x00000007)

            // Testing >> 2...
            // c : -00255 (0xFFFFFF01)
            // c >> 1 : -00128 (0xFFFFFF80)
            // c >> 2 : -00064 (0xFFFFFFC0)
            // c >> 5 : -00008 (0xFFFFFFF8)
        }
    }
}
