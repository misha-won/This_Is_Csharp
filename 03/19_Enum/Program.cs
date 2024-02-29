using System;

namespace _19_Enum
// 열거 형식은 같은 범주에 속하는 상수를 여러 개 선언할 때 유용하다!
{
    internal class Program
    {
        // 열거 형식 선언 방법
        // enum 열거_형식명 : 기반 자료형 { 상수1, 상수2, 상수3, ... }
        enum DialogResult { YES, NO, CANCEL, CONFIRM, OK }

        static void Main(string[] args)
        {
            Console.WriteLine((int)DialogResult.YES);       // 0
            Console.WriteLine((int)DialogResult.NO);        // 1
            Console.WriteLine((int)DialogResult.CANCEL);    // 2
            Console.WriteLine((int)DialogResult.CONFIRM);   // 3
            Console.WriteLine((int)DialogResult.OK);        // 4
            // 열거 형식의 각 요소가 가지는 값은 직접 지정하지 않을 경우
            // 컴파일러가 자동으로 할당한다(0에서부터 시작하여 1씩 증가).
            // 열거 형식의 각 요소는 서로 중복되지 않는 값을 가지고 있다는 데 의미가 있다.
            // 따라서 열거 형식을 사용할 때는 각 요소가 가지고 있는 값보다
            // 각 요소의 이름을 사용하는 것이 그 의미에 잘 부합한다고 할 수 있다.
        }
    }
}
