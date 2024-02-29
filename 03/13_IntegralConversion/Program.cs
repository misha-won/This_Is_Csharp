// 형식 변환(Type Conversion) : 변수를 다른 데이터 형식의 변수에 옮겨 담는 것
// 박싱과 언박싱도 값 형식과 참조 형식 간의 형식 변환이라고 할 수 있다.

// 다섯 가지 형식 변환
// - 크기(표현 범위)가 다른 정수 형식 사이의 변환
// - 크기(표현 범위)가 다른 부동 소숫점 형식 사이의 변환
// - 부호 있는 정수 형식과 부호 없는 정수 형식 사이의 변환
// - 부동 소숫점 형식과 정수 형식 사이의 변환
// - 문자열과 숫자 사이의 변환

using System;

namespace _13_IntegralConversion
// 크기(표현 범위)가 다른 정수 형식 사이의 변환
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte a = 127;
            Console.WriteLine(a);   // 127

            int b = (int)a;
            Console.WriteLine(b);   // 127

            int x = 128; // sbyte의 최댓값 127보다 1 큰 수
            Console.WriteLine(x);   // 128

            sbyte y = (sbyte)x; // 오버플로 발생!
            Console.WriteLine(y);   // -128
        }
    }
}
