// 6.3 매개변수에 대하여

// 값에 의한 전달(pass by value)
// - 메서드를 호출할 때 데이터를 복사해서 매개변수에 넘기는 것
// - 메서드 안에서 일어난 인수의 변화는 매개변수에 영향을 미치지 않는다.

namespace _03_SwapByValue
{
    internal class Program
    {
        public static void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;

            Console.WriteLine($"x: {x}, y: {y}");   // x: 3, y: 4

            Swap(x, y);

            Console.WriteLine($"x: {x}, y: {y}");   // x: 3, y: 4
        }
    }
}
