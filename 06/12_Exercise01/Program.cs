// 연습문제 01

// 다음 코드에서 Square() 메서드를 구현해 프로그램을 완성하세요.
// Square() 메서드는 매개변수를 제곱하여 반환합니다.
// 프로그램의 실행 예는 다음과 같습니다.

// ------------------------------
// 수를 입력하세요 : 3
// 결과 : 9

// 수를 입력하세요 : 34.2
// 결과 : 1169.64
// ------------------------------

namespace _12_Exercise01
{
    internal class Program
    {
        static double Square(double arg)
        {
            return arg * arg;
        }

        static void Main(string[] args)
        {
            Console.Write("수를 입력하세요 : ");
            string? input = Console.ReadLine();
            if (double.TryParse(input, out double arg))
                arg = Convert.ToDouble(input);

            Console.WriteLine("결과 : {0}", Square(arg));
        }
    }
}
