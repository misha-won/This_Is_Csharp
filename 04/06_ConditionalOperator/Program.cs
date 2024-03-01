// 조건 연산자(Conditional Operator)
// 조건식 ? 참일_때의_값 : 거짓일_때의_값

namespace _06_ConditionalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = (10 % 2) == 0 ? "짝수" : "홀수";
            Console.WriteLine(result);  // 짝수
        }
    }
}
