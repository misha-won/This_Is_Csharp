using System;

namespace _32_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ==================================================
            // 연습문제 01
            // 사용자로부터 사각형의 너비와 높이를 입력받아 넓이를 계산하는 프로그램을 완성하세요.

            Console.WriteLine("사각형의 너비를 입력하세요.");
            string? width = Console.ReadLine();

            Console.WriteLine("사각형의 높이를 입력하세요.");
            string? height = Console.ReadLine();

            if (int.TryParse(width, out int w) && int.TryParse(height, out int h))
            {
                Console.WriteLine("사각형의 넓이는 : " + w * h);
            }
            else
            {
                Console.WriteLine("잘못된 형식입니다.");
            }

            // ==================================================
            // 연습문제 02
            // 다음 코드에서 잘못된 부분을 찾고, 그 이유를 설명하세요.

            // int a = 7.3;         -> int a = 7;       / double a = 7.3;
            // float b = 3.14;      -> float b = 3.14f; / double b = 3.14;
            // double c = a * b;    -> float c = a * b; / double c = (double)a * b;
            // char d = "abc";      -> char d = 'a';    / string d = "abc";
            // string e = '한';     -> string e = "한"; / char e = '한';

            // ==================================================
            // 연습문제 03
            // 값 형식과 참조 형식의 차이는 무엇인가요?

            // 값 형식은 변수가 값을 담는 데이터 형식이다.
            // 참조 형식은 변수가 값의 위치(참조)를 담는 데이터 형식이다.
            // 값 형식 데이터와 참조 형식 데이터는 저장되는 메모리 영역의 종류가 다르다.
            // 값 형식 데이터는 스택에 저장되고, 참조 형식 데이터는 힙에 저장된다.

            // ==================================================
            // 연습문제 04
            // 박싱과 언박싱을 설명하세요.

            // 박싱은 참조 형식의 변수에 값 형식 데이터를 할당하려는 시도가 이루어질 때
            // 해당 데이터를 박스에 담아 힙에 할당하는 과정이다.
            // 한편, 언박싱은 박싱된 값을 꺼내 값 형식 변수에 저장하는 과정이다.

            // ==================================================
            // 연습문제 05
            // 다음 코드를 컴파일 한 후의 a와 b는 각각 어떤 데이터 형식이겠습니까?

            var a = 2020;       // int 형식
            var b = "double";   // string 형식
        }
    }
}
