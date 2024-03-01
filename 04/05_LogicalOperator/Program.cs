// 4.6 논리 연산자(Logical Operator, Boolean Operator)
// 참과 거짓으로 이루어지는 진릿값이 피연산자인 연산자

// C#에서 제공하는 논리 연산자
// - 논리곱 연산자(&& : AND)
// - 논리합 연산자(|| : OR)
// - 부정 연산자(! : NOT)

namespace _05_LogicalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing && ...");
            Console.WriteLine($"1 > 0 && 4 < 5 : {1 > 0 && 4 < 5}");
            Console.WriteLine($"1 > 0 && 4 > 5 : {1 > 0 && 4 > 5}");
            Console.WriteLine($"1 == 0 && 4 > 5 : {1 == 0 && 4 > 5}");
            Console.WriteLine($"1 == 0 && 4 < 5 : {1 == 0 && 4 < 5}");

            Console.WriteLine("\nTesting || ...");
            Console.WriteLine($"1 > 0 || 4 < 5 : {1 > 0 || 4 < 5}");
            Console.WriteLine($"1 > 0 || 4 > 5 : {1 > 0 || 4 > 5}");
            Console.WriteLine($"1 == 0 || 4 > 5 : {1 == 0 || 4 > 5}");
            Console.WriteLine($"1 == 0 || 4 < 5 : {1 == 0 || 4 < 5}");

            Console.WriteLine("\nTesting ! ...");
            Console.WriteLine($"!True : {!true}");
            Console.WriteLine($"!False : {!false}");

            // Testing && ...
            // 1 > 0 && 4 < 5 : True
            // 1 > 0 && 4 > 5 : False
            // 1 == 0 && 4 > 5 : False
            // 1 == 0 && 4 < 5 : False

            // Testing || ...
            // 1 > 0 || 4 < 5 : True
            // 1 > 0 || 4 > 5 : True
            // 1 == 0 || 4 > 5 : False
            // 1 == 0 || 4 < 5 : True

            // Testing ! ...
            // !True : False
            // !False : True
        }
    }
}
