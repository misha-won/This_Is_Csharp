// 4.11 null 병합 연산자(??)
// - 두 개의 피연산자를 받아들이고 왼쪽 피연산자가 null인지 평가한다.
// - 평가 결과가 null이 아닌 것으로 나타나면 왼쪽 피연산자를 그대로 반환한다.
// - 평가 결과가 null인 것으로 평가되면 오른쪽 피연산자를 반환한다.

// * C#에서는 null과 관계된 형식과 연산자에 ? 기호가 들어간다.

namespace _11_NullCoalescing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? num = null;
            Console.WriteLine($"{num ?? 0}");           // 0

            num = 99;
            Console.WriteLine($"{num ?? 0}");           // 99

            string str = null;
            Console.WriteLine($"{str ?? "Default"}");   // Default

            str = "Specific";
            Console.WriteLine($"{str ?? "Default"}");   // Specific
        }
    }
}

// 4.12 연산자의 우선순위
// 증가/감소 연산자, null 조건부 연산자 > 산술 연산자 > 시프트 연산자 > 관계 연산자
// > 비트 논리 연산자 > 논리 연산자 > null 병합 연산자 > 조건 연산자 > 할당 연산자

// [1] (후위)++/-- ?. ?[]
// [2] (전위)++/--
// [3] * / %
// [4] + -
// [5] << >>
// [6] < > <= >= is as
// [7] == !=
// [8] &
// [9] ^
// [10] |
// [11] &&
// [12] ||
// [13] ??
// [14] ?:
// [15] = *= /= %= += -= <= >= &= ^= |=