// 6.7 메서드 오버로딩(Method Overloading)
// 하나의 메서드 이름에 여러 개의 구현을 올리는 것을 뜻한다.

// 메서드를 오버로딩하면, 컴파일러가 메서드 호출 코드에 사용되는 매개변수의 수와 형식을 분석해서
// (오로지 매개변수만 분석한다. 반환 형식은 묻지도 따지지도 않는다) 어떤 버전이 호출될지를 찾아
// 준다. 실행할 메서드의 버전을 찾는 작업이 컴파일 타임에 이루어지므로 성능 저하의 문제도 없다.

// ※ 메서드 오버로딩은 이름에 대한 고민을 줄여 주는 동시에 코드를 일관성 있게 유지해 준다.
// 일관성 있는 코드는 메서드 작성자를 도울 뿐만 아니라 메서드 사용자에게도 높은 생산성을 제공한다.

namespace _07_Overloading
{
    internal class Program
    {
        static int Plus(int a, int b)
        {
            Console.WriteLine("Calling int Plus(int, int)...");
            return a + b;
        }

        static int Plus(int a, int b, int c)
        {
            Console.WriteLine("Calling int Plus(int, int, int)...");
            return a + b + c;
        }

        static double Plus(double a, double b)
        {
            Console.WriteLine("Calling double Plus(double, double)...");
            return a + b;
        }

        static double Plus(int a, double b)
        {
            Console.WriteLine("Calling double Plus(int, double)...");
            return a + b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Plus(1, 2));
            Console.WriteLine(Plus(1, 2, 3));
            Console.WriteLine(Plus(1.0, 2.4));
            Console.WriteLine(Plus(1, 2.4));

            // Calling int Plus(int, int)...
            // 3
            // Calling int Plus(int, int, int)...
            // 6
            // Calling double Plus(double, double)...
            // 3.4
            // Calling double Plus(int, double)...
            // 3.4
        }
    }
}
