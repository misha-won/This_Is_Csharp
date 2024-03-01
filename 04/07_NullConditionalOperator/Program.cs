// 4.8 null 조건부 연산자

// ?. : 객체의 멤버에 접근하기 전에 해당 객체가 null인지 검사하여
//      그 결과가 참(즉, 객체가 null)이면 null을 반환하고,
//      그렇지 않은 경우에는 . 뒤에 지정된 멤버를 반환한다.

// ?[] : 객체의 멤버 접근이 아닌 배열과 같은 컬렉션 객체의 첨자를
//       이용한 참조에 사용된다.

using System.Collections;
using static System.Console;

namespace _07_NullConditionalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = null;
            a?.Add("야구"); // a?.가 null을 반환하므로 Add() 메서드 호출 X
            a?.Add("축구");
            WriteLine($"Count : {a?.Count}");
            WriteLine($"{a?[0]}");
            WriteLine($"{a?[1]}");

            a = new ArrayList(); // a는 이제 더 이상 null이 아니다.
            a?.Add("야구");
            a?.Add("축구");
            WriteLine($"Count : {a?.Count}");
            WriteLine($"{a?[0]}");
            WriteLine($"{a?[1]}");

            // Count :
            // 
            // 
            // Count : 2
            // 야구
            // 축구
        }
    }
}
