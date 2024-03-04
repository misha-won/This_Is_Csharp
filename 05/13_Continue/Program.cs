// 5.3.2 continue
// 한 회 건너 뛰어 반복을 계속 수행하게 하는 점프문
// continue 문을 사용하면 코드의 가독성이 훨씬 좋아진다.
// (코드가 복잡하고 길어질수록 그 차이를 확연하게 느낄 수 있다.)

namespace _13_Continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                    continue;

                Console.WriteLine($"{i} : 홀수");
            }

            // 1 : 홀수
            // 3 : 홀수
            // 5 : 홀수
            // 7 : 홀수
            // 9 : 홀수
        }
    }
}
