using System;

namespace _22_Nullable
// Nullable 형식은 변수에게 할당된 메모리 공간을 비워 둘 수 있다.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nullable 형식 변수 선언 방법
            // 데이터_형식? 변수_이름;

            // int? a = null; <- 해당 변수를 비운다는 뜻
            // int a; <- 문법적으로는 아무 문제가 없는 변수 선언문
            // 하지만 int a = null;과 같은 뜻을 가지는 것은 아님
            // int 형식은 비워 둘 수 없는(null 값을 가질 수 없는) 데이터 형식이므로!

            // Nullable 형식은 값 형식에 한해서 사용할 수 있다(참조 형식은 사용 불가).

            // 모든 Nullable 형식은 HasValue와 Value 두 가지 속성을 가지고 있다.
            // HasValue : 해당 변수가 값을 갖고 있는지 또는 그렇지 않은지를 나타낸다.
            // Value : 변수에 담겨 있는 값을 나타낸다.

            int? a = null;

            Console.WriteLine(a.HasValue);  // False
            Console.WriteLine(a != null);   // False

            a = 3;
            Console.WriteLine(a.HasValue);  // True
            Console.WriteLine(a != null);   // True
            Console.WriteLine(a.Value);     // 3
        }
    }
}
