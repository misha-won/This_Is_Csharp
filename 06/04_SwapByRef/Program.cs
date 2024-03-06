// 6.4 참조에 의한 매개변수 전달

// 참조에 의한 전달(pass by reference)
// - 값에 의한 전달과 달리, 매개변수가 메서드에 넘겨진 원본 변수를 직접 참조한다.
// - 메서드 안에서 매개변수를 수정하면 그 매개변수가 참조하고 있는 원본 변수에 수정이 이루어진다.

namespace _04_SwapByRef
{
    internal class Program
    {
        // ref 키워드를 사용하여 참조에 의한 매개변수 전달하기
        static void Swap(ref int a , ref int b) // 1. 매개변수 앞에 ref 키워드를 붙인다.
        {
            int temp = b;
            b = a;
            a = temp;
        }

        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;

            Console.WriteLine($"x: {x}, y:{y}");    // x: 3, y: 4

            Swap(ref x, ref y); // 2. 메서드를 호출할 때 다시 ref 키워드를 매개변수 앞에 붙인다.

            Console.WriteLine($"x: {x}, y:{y}");    // x: 4, y: 3
        }
    }
}
