// 4.5 관계 연산자(Relational Operator)

// 두 연산자 사이의 관계를 평가하는 연산자
// <, >, <=, >= : 모든 수치 형식과 열거 형식 지원
// == : 모든 데이터 형식 지원
// != : 모든 데이터 형식 지원, string과 object 형식에 대해서도 사용 가능

namespace _04_RelationalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"3 > 4 : {3 > 4}");      // 3 > 4 : False
            Console.WriteLine($"3 >= 4 : {3 >= 4}");    // 3 >= 4 : False
            Console.WriteLine($"3 < 4 : {3 < 4}");      // 3 < 4 : True
            Console.WriteLine($"3 <= 4 : {3 <= 4}");    // 3 <= 4 : True
            Console.WriteLine($"3 == 4 : {3 == 4}");    // 3 == 4 : False
            Console.WriteLine($"3 != 4 : {3 != 4}");    // 3 != 4 : True
        }
    }
}
