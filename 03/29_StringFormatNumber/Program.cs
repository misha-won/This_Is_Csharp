using System;
using static System.Console;

// 숫자 서식화
// {첨자, 맞춤: 서식 문자열}의 형식

// 서식 지정자(Format Specifier)
// D : 10진수
// X : 16진수
// N : 콤마(,)로 묶어 표현한 수
// F : 고정 소수점
// E : 지수
// 자릿수 지정자(Precision Specifier)와 함께 사용할 수 있다.

namespace _29_StringFormatNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // D : 10진수
            WriteLine("10진수: {0:D}", 123);
            // WriteLine(string.Format("10진수: {0:D}", 123));과 동일
            WriteLine("10진수: {0:D5}", 123);

            // X : 16진수
            WriteLine("16진수: 0x{0:X}", 0xFF1234);
            WriteLine("16진수: 0x{0:X8}", 0xFF1234);

            // N : 숫자
            WriteLine("숫자: {0:N}", 123456789);
            WriteLine("숫자: {0:N0}", 123456789);
            // 자릿수 0은 소수점 이하를 제거함

            // F : 고정 소수점
            WriteLine("고정 소수점: {0:F}", 123.456);
            WriteLine("고정 소수점: {0:F5}", 123.456);

            // E : 공학용
            WriteLine("공학: {0:E}", 123.456789);

            // 10진수: 123
            // 10진수: 00123
            // 16진수: 0xFF1234
            // 16진수: 0x00FF1234
            // 숫자: 123,456,789.00
            // 숫자: 123,456,789
            // 고정 소수점: 123.45
            // 고정 소수점: 123.45600
            // 공학: 1.234568E+002
        }
    }
}
