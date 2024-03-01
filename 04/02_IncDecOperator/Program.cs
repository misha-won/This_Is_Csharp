// 4.3 증가 연산자와 감소 연산자

// 증가 연산자(Increment Operator) : 피연산자의 값을 1 증가시킴
// 감소 연산자(Decrement Operator) : 피연산자의 값을 1 감소시킴

// 단항 연산자(Unary Operator) : 피연산자를 하나만 받는 연산자

// 전위 증가/감소 연산자 vs. 후위 증가/감소 연산자
// - 변수 앞에 사용 시 변수의 값을 변경한 후에 해당 문장이 실행된다.
// - 변수 뒤에 사용 시 해당 문장의 실행이 끝난 후 변수의 값이 변경된다.

namespace _02_IncDecOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a++); // 10
            Console.WriteLine(++a); // 12

            Console.WriteLine(a--); // 12
            Console.WriteLine(--a); // 10
        }
    }
}
