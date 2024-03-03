// 5.2.6 for 또는 while을 이용한 무한 반복 코드

// 다음과 같이 for 문의 매개변수에 아무것도 넣지 않으면 코드가 무한하게 반복 실행된다.

// for ( ; ; )
//     반복_실행할_코드_블록;

// while 문은 조건식의 평가 결과가 항상 true가 되도록 만들면 코드가 무한 반복 실행된다.

// while (true)
//     반복_실행할_코드_블록;

// ※ 무한 반복 예제 프로그램은 Ctrl + C 키를 눌러 종료하거나
//    작업 관리자에서 프로세스 이름을 찾아 강제 종료시키면 된다.

namespace _11_InfiniteForWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int i = 0;

            // for ( ; ; )
            //     Console.WriteLine(i++);

            // while (true)
            //     Console.WriteLine(i++);

            // 0
            // 1
            // ...
            // 55555
            // 55556
            // 55557
            // ...
        }
    }
}
