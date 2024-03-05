// 6.2 return에 대하여

// return 문
// - 프로그램의 흐름을 호출자에게로 돌려놓는 점프문이다.
// - 언제든지 메서드 중간에 호출되어 메서드를 종결시킬 수 있다.
// - 메서드가 반환할 것이 아무것도 없는 경우(반환 형식이 void인 경우)에도 사용할 수 있다.

namespace _02_Return
{
    internal class Program
    {
        static int Fibonacci(int n)
        {
            if (n < 2)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void PrintProfile(string name, string phone)
        {
            if (name == "")
            {
                Console.WriteLine("이름을 입력해 주세요.");
                return;
            }

            Console.WriteLine($"Name: {name}, Phone: {phone}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"10번째 피보나치 수 : {Fibonacci(10)}");

            PrintProfile("", "123-4567");
            PrintProfile("박상현", "456-1230");

            // 10번째 피보나치 수 : 55

            // 이름을 입력해 주세요.
            // Name: 박상현, Phone: 456-1230
        }
    }
}
