// 연습문제 02

// 다음 코드에서 Plus() 메서드가 double형 매개변수를 지원하도록 오버로딩하세요.
// 이 프로그램이 완성된 후의 실행 결과는 다음과 같아야 합니다.

// ------------------------------
// 3 + 4 = 7
// 2.4 + 3.1 = 5.5
// ------------------------------

namespace _13_Exercise02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;
            int resultA = 0;

            Plus(a, b, out resultA);

            Console.WriteLine("{0} + {1} = {2}", a, b, resultA);

            double x = 2.4;
            double y = 3.1;
            double resultB = 0;

            Plus(x, y, out resultB);

            Console.WriteLine("{0} + {1} = {2}", x, y, resultB);
        }

        public static void Plus(int a, int b, out int c)
        {
            c = a + b;
        }

        // 이 아래에 double형 매개변수를 받을 수 있도록 오버로딩된 Plus() 메서드를 작성하세요.
        public static void Plus(double a, double b, out double c)
        {
            c = a + b;
        }
    }
}
