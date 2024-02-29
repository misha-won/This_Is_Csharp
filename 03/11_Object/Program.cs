using System;

namespace _11_Object
// C#은 object가 모든 데이터를 다룰 수 있도록 하기 위해 모든 데이터 형식
// (기본 데이터 형식뿐 아니라 모든 복합 데이터 형식, 심지어 프로그래머가 만드는 데이터 형식마저도)이
// 자동으로 object 형식으로부터 상속받게 했다.
// 다시 말해, object 형식은 모든 데이터 형식의 조상이다.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object a = 123;
            object b = 3.141592653589793238462643383279m;
            object c = true;
            object d = "안녕하세요";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
