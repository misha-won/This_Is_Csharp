// 5.2.2 do while

// while 문은 조건식을 평가한 후 그 결과가 참이면 코드를 실행하는 데 반해,
// do while 문은 조건식을 평가하기 전에 무조건 처음 한 번은 코드를 실행한다.

// do while 문은 끝에 세미콜론(;)을 반드시 붙여 줘야 한다.

// do
// {
//     반복_실행할_코드_블록;
// }
// while (조건식);

namespace _07_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            do
            {
                Console.WriteLine("a) i : {0}", i--);
            }
            while (i > 0);

            do
            {
                // 여기에서 i는 이미 0이지만 이 코드는 한 차례 실행된다.
                Console.WriteLine("b) i : {0}", i--);
            }
            while (i > 0);

            // a) i : 10 // a) i : 9  // a) i : 8  // a) i : 7  // a) i : 6
            // a) i : 5  // a) i : 4  // a) i : 3  // a) i : 2  // a) i : 1
            // b) i : 0
        }
    }
}
