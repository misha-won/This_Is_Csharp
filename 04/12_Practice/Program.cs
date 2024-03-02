namespace _12_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 01

            // 연습문제 01
            // i++와 ++i의 차이점은 무엇인가요?

            // 정답
            // i++는 해당 문장의 실행이 끝난 후 i의 값이 1 증가하고,
            // ++i는 i의 값이 1 증가한 후에 해당 문장이 실행된다.

            #endregion Exercise 01

            #region Exercise 02

            // 연습문제 02
            // 다음 보기 중에서 그 결과가 다른 것을 찾으세요.
            // (변수 i를 초기화해서 각 보기를 실행해 보면 그 결과가 나옵니다)

            // (1) i = i + 1;
            // (2) i++; 
            // (3) ++i;
            // (4) i += 1;

            // 정답 : 2번

            #endregion Exercise 02

            #region Exercise 03

            // 연습문제 03
            // 다음 코드에서 a와 b는 각각 얼마일까요?

            int a = 8 >> 1;
            int b = a >> 2;

            // 풀이
            // a = 0b_0000_0100 >> 1 = 0b_0000_0010
            // b = 0b_0000_0010 >> 2 = 0b_0000_0000

            // 정답 : a = 4, b = 0

            #endregion Exercise 03

            #region Exercise 04

            // 연습문제 04
            // 다음 코드에서 c는 얼마일까요?

            int c = 0xF0 | 0x0F;

            // 풀이 : 0b_1111_0000 | 0b_1111_1111 = 0b_1111_1111

            // 정답 : 255

            #endregion Exercise 04

            #region Exercise 05

            // 연습문제 05
            // 다음 코드에서 e는 어떤 값을 가질까요?

            int d = 10;
            string e = d == 0 ? "가나다" : "ABC";

            // 정답 : "ABC"

            #endregion Exercise 05
        }
    }
}
