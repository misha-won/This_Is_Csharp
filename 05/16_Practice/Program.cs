namespace _16_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Chapter 05 연습문제

            #region Exercise 01
            // 다음과 같은 결과를 출력하는 프로그램을 for 문을 이용하여 작성하세요.
            // 첫 번째 줄에 별 1개, 두 번째 줄에 별 2개, 세 번째 줄에 별 3개...
            // 이런 식으로 별 5개가 찍힐 때까지 반복합니다.
            // (힌트: for 문 블록 아네 for 블록을 넣으세요.)

            // *
            // **
            // ***
            // ****
            // ******

            int i, j;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion Exercise 01

            #region Exercise 02
            // 다음과 같은 결과를 출력하는 프로그램을 for 문을 이용하여 작성하세요.

            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5 - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // *****
            // ****
            // ***
            // **
            // *

            #endregion Exercise 02

            #region Exercise 03
            // 1번과 2번을 for 문 대신 while 문과 do 문으로 바꿔서 각각 작성하세요.

            i = 0;

            while (i < 5)
            {
                j = 0;

                while (j <= i)
                {
                    Console.Write("*");
                    j++;
                }

                Console.WriteLine();
                i++;
            }

            i = 0;

            do
            {
                j = 0;
                do
                {
                    Console.Write("*");
                    j++;
                }
                while (j < 5 - i);

                Console.WriteLine();
                i++;
            }
            while (i < 5);

            #endregion Exercise 03

            #region Exercise 04
            // 다음과 같이 사용자로부터 입력받은 횟수만큼 별을 반복 출력하는 프로그램을 작성하세요.
            // 단, 입력받은 수가 0보다 작거나 같을 경우 '0보다 같거나 작은 숫자는 사용할 수
            // 없습니다.'라는 메시지를 띄우고 프로그램을 종료합니다.

            // 반복 횟수를 입력하세요 : -10
            // 0보다 같거나 작은 수는 사용할 수 없습니다.

            // 반복 횟수를 입력하세요 : 5
            // *
            // **
            // ***
            // ****
            // *****

            Console.Write("반복 횟수를 입력하세요 : ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int num))
            {
                if (num <= 0)
                {
                    Console.WriteLine("0보다 같거나 작은 수는 사용할 수 없습니다.");
                    return;
                }

                for (i = 0; i < num; i++)
                {
                    for (j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다. 정수를 입력하세요.");
            }

            #endregion Exercise 04
        }
    }

    #region Exercise 05
    // 다음 Fibonacci 클래스의 GetNumber() 메서드에서 switch 문을 switch 식으로 변경하세요.

    class Fibonacci
    {
        public static long GetNumber(long index)
        {
            // long result = 0;
            // switch (index)
            // {
            //     case 0:
            //         result = 0;
            //         break;
            //     case 1:
            //         result = 1;
            //         break;
            //     default:
            //         result = GetNumber(index - 1) + GetNumber(index - 2);
            //         break;
            // }

            long result = index switch
            {
                0 => 0,
                1 => 1,
                _ => GetNumber(index - 1) + GetNumber(index - 2)
            };

            return result;
        }
    }

    #endregion Exercise 05
}
