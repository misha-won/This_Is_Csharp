// 6.8 가변 개수의 인수
// - 그 개수가 유연하게 변할 수 있는 인수를 뜻한다.
// - params 키워드와 배열을 이용하여 선언한다.

// 가변 개수의 인수와 메서드 오버로딩
// 1) 메서드 오버로딩은 매개변수의 개수뿐 아니라 형식이 다른 경우에도 사용할 수 있다.
// 2) 매개변수의 개수가 유한하게 정해져 있다면 가변 개수의 인수보다는 메서드 오버로딩을 사용하는
//    것이 적절하다. 가변 개수의 인수는 형식은 같으나 인수의 개수만 유연하게 달라질 수 있는 경우에
//    적합하다.

namespace _08_UsingParams
{
    internal class Program
    {
        static int Sum(params int[] args)
        {
            Console.WriteLine("Summing... ");

            int sum = 0;

            for (int i = 0; i < args.Length; i++)
            {
                if (i > 0)
                    Console.Write(", ");
                Console.Write(args[i]);

                sum += args[i];
            }
            Console.WriteLine();

            return sum;
        }

        static void Main(string[] args)
        {
            int sum = Sum(3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine($"Sum : {sum}");

            // Summing... 3, 4, 5, 6, 7, 8, 9, 10
            // Sum : 52
        }
    }
}
