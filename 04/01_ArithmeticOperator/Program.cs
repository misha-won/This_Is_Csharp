// Chapter 04. 데이터를 가공하는 연산자

// 4.1 C#에서 제공하는 연산자 둘러보기

// C#이 제공하는 주요 연산자들
// - 산술 연산자 : +, -, *, /, %
// - 증감 연산자 : ++, --
// - 관계 연산자 : <, >, ==, !=, <=, >=
// - 논리 연산자 : &&, ||, !
// - 조건 연산자 : ?:
// - null 조건부 연산자 : ?., ?[]
// - 비트 연산자 : <<, >>, &, |, ^, ~
// - 할당 연산자 : =, +=, -=, *=, /=, %=, &=, |=, ^=, <<=, >>=
// - null 병합 연산자 : ??

// 4.2 산술 연산자(Arithmatic Operator)
// - 수치 형식의 데이터를 다루는 연산자
// - 이항 연산자(Binary Operator) : 두 개의 피연산자가 필요한 연산자

namespace _01_ArithmeticOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 111 + 222;
            Console.WriteLine($"a : {a}");

            int b = a - 100;
            Console.WriteLine($"b : {b}");

            int c = b * 10;
            Console.WriteLine($"c : {c}");

            double d = c / 6.3;
            // 피연산자 중 한쪽이 부동 소수형이면 부동 소수형 버전의 연산자가 사용되며,
            // 나머지 피연산자도 부동 소수형으로 형변환된다.
            Console.WriteLine($"d : {d}");

            Console.WriteLine($"22 / 7 = {22 / 7}({22 % 7})");

            // a : 333
            // b : 233
            // c : 2330
            // d : 369.8412698412699
            // 22 / 7 = 3(1)
        }
    }
}
