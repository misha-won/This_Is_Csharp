// Chapter 05 코드의 흐름 제어하기

// 이 장의 핵심 개념
// - 프로그래밍에서 흐름 제어(Flow Control)의 역할을 이해합니다.
// - 분기문을 이해하고 사용 방법을 익힙니다.
// - 반복문을 이해하고 사용 방법을 익힙니다.
// - 점프문을 이해하고 사용 방법을 익힙니다.

// 이 장의 학습 흐름
// > 분기문
// > if, else, 그리고 else if
// > if 문 중첩해서 사용하기
// > switch
// > 반복문
// > while
// > do while
// > for
// > 중첩 for
// > foreach
// > for 또는 while을 이용한 무한 반복 코드
// > 점프문
// > continue
// > goto
// > return과 throw

// 5.1 분기문(Branching Statement)
// 프로그램의 흐름을 조건에 따라 여러 갈래로 나누는 흐름 제어 구문

// if 문 : 한 번에 단 하나의 조건만 평가할 수 있는 분기문
// switch 문 : 한 번에 여러 개의 조건을 평가할 수 있는 분기문

// 5.1.1 if, else, else if

// if 문의 사용 형식

// if (조건식(bool 형식))
//     참인_경우에_실행할_코드;

// if (조건식)
// {
//     참인_경우에;
//     실행할;
//     코드;
// }

namespace _01_IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하세요 : ");

            string? input = Console.ReadLine();
            if (int.TryParse(input, out int number))
                number = int.Parse(input);

            if (number < 0)
                Console.WriteLine("음수");
            else if (number > 0)
                Console.WriteLine("양수");
            else
                Console.WriteLine("0");

            if (number % 2 == 0)
                Console.WriteLine("짝수");
            else
                Console.WriteLine("홀수");

            // 숫자를 입력하세요 : 33
            // 양수
            // 홀수

            // 숫자를 입력하세요 : -12
            // 음수
            // 짝수
        }
    }
}
