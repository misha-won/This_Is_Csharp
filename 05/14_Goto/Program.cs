// 5.3.3 goto

// goto 문의 사용 형식

// goto 레이블;

// 레이블 :
// 	이어지는_코드;

// 레이블(Label)은 코드 안의 위치를 나타내는 표지판 같은 존재이다.
// 레이블을 선언할 때는 콜론(:)을 붙인다.

// goto 문의 해악?
// goto 문은 코드의 이곳저곳으로 텔레포트하면서 흐름을 자주 끊어 코드를 읽기 어렵게 만들기 떄문에
// 상당수의 프로그래머는 goto 문의 사용을 선호하지 않는다.
// 그래도 goto 문은 중첩된 반복문을 단번에 뚫고 나오는 데 유용하다는 장점이 있다.

namespace _14_Goto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("종료 조건(숫자)을 입력하세요 : ");

            string? input = Console.ReadLine();

            if (int.TryParse(input, out int input_number))
                input_number = Convert.ToInt32(input);

            int exit_number = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (exit_number++ == input_number)
                            goto EXIT_FOR;

                        Console.WriteLine(exit_number);
                    }
                }
            }

            goto EXIT_PROGRAM;

        EXIT_FOR:
            Console.WriteLine("Exit nested for...");

        EXIT_PROGRAM:
            Console.WriteLine("Exit program...");

            // 종료 조건(숫자)을 입력하세요 : 5
            // 1
            // 2
            // 3
            // 4
            // 5
            // Exit nested for...
            // Exit program...

            // 종료 조건(숫자)을 입력하세요 : 20
            // 1
            // 2
            // 3
            // 4
            // 5
            // 6
            // 7
            // 8
            // 9
            // 10
            // 11
            // 12
            // Exit program...
        }
    }
}
