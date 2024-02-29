using System;

namespace _21_Enum3
{
    internal class Program
    {
        enum DialogResult { YES = 10, NO, CANCEL, CONFIRM = 50, OK }
        // 열거 형식의 각 요소에 원하는 값을 직접 대입할 수도 있다.
        // 직접 값을 할당하지 않은 나머지 요소는 컴파일러가 자동으로 값을 할당한다.

        static void Main(string[] args)
        {
            Console.WriteLine((int)DialogResult.YES);       // 10
            Console.WriteLine((int)DialogResult.NO);        // 11
            Console.WriteLine((int)DialogResult.CANCEL);    // 12
            Console.WriteLine((int)DialogResult.CONFIRM);   // 50
            Console.WriteLine((int)DialogResult.OK);        // 51
        }
    }
}
