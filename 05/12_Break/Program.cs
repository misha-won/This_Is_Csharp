// 5.3 점프문(Jump Statement)
// 코드의 흐름을 끊고 프로그램의 실행 위치를 원하는 곳으로 이동시키는 흐름 제어문

// - break
// - continue
// - goto
// - return
// - throw

// 5.3.1 break
// break : [동사] 탈출하다, 중단하다
// break 문 : 반복문이나 switch 문의 실행을 중단하고자 할 때 사용하는 점프문

namespace _12_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("계속할까요?(예/아니오) : ");
                string? answer = Console.ReadLine();

                if (answer == "아니오")
                    break;
            }

            // 계속할까요?(예/아니오) : 예
            // 계속할까요?(예/아니오) : 예
            // 계속할까요?(예/아니오) : 예
            // 계속할까요?(예/아니오) : 예
            // 계속할까요?(예/아니오) : 예
            // 계속할까요?(예/아니오) : 아니오
        }
    }
}
