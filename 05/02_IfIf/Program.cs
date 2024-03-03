// 5.1.2 if 문 중첩해서 사용하기
// 보통은 다른 종류의 흐름 제어문을 중첩(Nesting)하는 편인데,
// 유독 if 문과 for 문 등은 같은 종류의 흐름 제어문을 자주 중첩해서 사용한다.
// (switch 문이나 while 문은 가독성 등의 이유로 중첩을 잘 하지 않는 편이다.)

// ※ 중첩으로 프로그램의 흐름을 '갈기갈기' 찢어놓는 것은 좋은 코드가 아니다.
// ※ 코드의 흐름은 가급적 단순하고 명료하게 유지하는 것이 좋다.

// 컴퓨터가 이해할 수 있는 코드는 어느 바보나 다 짤 수 있다.
// 좋은 프로그래머는 사람이 이해할 수 있는 코드를 짠다. - 마틴 파울러

namespace _02_IfIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하세요 : ");

            string? input = Console.ReadLine();
            if (int.TryParse(input, out int number))
                number = Convert.ToInt32(number);

            if (number > 0)
            {
                if (number % 2 == 0)
                    Console.WriteLine("0보다 큰 짝수");
                else
                    Console.WriteLine("0보다 큰 홀수");
            }
            else
            {
                Console.WriteLine("0보다 작거나 같은 수");
            }

            // 숫자를 입력하세요 : 11
            // 0보다 큰 홀수

            // 숫자를 입력하세요 : 4
            // 0보다 큰 짝수

            // 숫자를 입력하세요 : -10
            // 0보다 작거나 같은 수
        }
    }
}
