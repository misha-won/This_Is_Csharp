using System;

namespace _17_StringNumberConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string a = "12345";
            // int b = (int)a;      // 컴파일 불가능, 오류 발생
            // (int) 강제 형변환 연산자는 다른 숫자 형식 데이터를 int 형식으로 변환하는 방법
            // (그리고 object 형식을 언박싱하는 방법도 함께)을 가지고 있긴 하지만,
            // string을 비롯한 여타 형식으로의 형식 변환 방법은 가지고 있지 않다.
            // 마찬가지로 (string)도 int 형식을 string 형식으로 변환할 수 없다.
            // 문자열, 숫자 간의 형식 변환에는 메소드가 필요하다.

            int a = 123;
            string b = a.ToString();
            Console.WriteLine(b);   // 123

            float c = 3.14f;
            string d = c.ToString();
            Console.WriteLine(d);   // 3.14

            string e = "123456";
            int f = Convert.ToInt32(e);
            Console.WriteLine(f);   // 123456

            string g = "1.2345";
            float h = float.Parse(g);
            Console.WriteLine(h);   // 1.2345
        }
    }
}
