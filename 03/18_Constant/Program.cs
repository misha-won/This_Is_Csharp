using System;

// 상수(Constant)와 열거(Enumerator) 형식
// - 변수와는 달리 안에 담긴 데이터를 절대 바꿀 수 없는 메모리 공간이다.

// 열거 형식의 장점
// - 컴파일러가 소스 코드를 컴파일할 때 프로그래머의 실수를 잡아 준다.
// - 그래서 결국에는 프로그램의 버그도 줄여 준다.

namespace _18_Constant
// 상수 선언 형식
// const 자료형 상수명 = 값;
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MAX_INT = 2147483647;
            const int MIN_INT = -2147483648;
            // MAX_INT = MIN_INT;
            // 오류 발생 : 할당식의 왼쪽은 변수, 속성 또는 인덱서여야 한다.

            Console.WriteLine(MAX_INT); // 2147483647
            Console.WriteLine(MIN_INT); // -2147483648
        }
    }
}
