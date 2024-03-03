// 5.2 반복문(Loop Statement)
// 특정 조건을 만족하는 동안 코드 또는 코드 블록을 반복해서 실행하도록 하는 문장

// 반복문의 종류
// - while
// - do while
// - for
// - foreach

// 5.2.1 while

// while (조건식)
//     반복_실행할_코드;

// while (조건식)
// {
//     반복_실행할;
//     코드_블록;
// }

// 이때, 조건식은 논리 형식(bool 형식)이어야 한다.

// 조건식이 false 값을 가지지 못한다면 무한 반복(Infinite Loop)이 발생한다.

namespace _06_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            while (i > 0)
                Console.WriteLine($"i : {i--}");

            // i : 10 // i : 9  // i : 8  // i : 7  // i : 6
            // i : 5  // i : 4  // i : 3  // i : 2  // i : 1
        }
    }
}
