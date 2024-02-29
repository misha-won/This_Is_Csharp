using System;

namespace _24_CTS
// 공용 형식 시스템(Common Type System, CTS)
// 모두가 함께 사용하는 데이터 형식 체계, 즉 .NET의 표준 형식 체계
// 여기에서 '모두'는 C#을 비롯한 .NET을 지원하는 모든 언어(.NET 언어)를 의미
// 다시 말해 CTS는 .NET 언어라면 반드시 따라야 하는 데이터 형식이다
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Int32 a = 123;
            int b = 456;

            Console.WriteLine("a type:{0}, value:{1}", a.GetType().ToString(), a);
            Console.WriteLine("b type:{0}, value:{1}", b.GetType().ToString(), b);
            // a type:System.Int32, value:123
            // b type:System.Int32, value:456

            System.String c = "abc";
            string d = "def";

            Console.WriteLine("c type:{0}, value:{1}", c.GetType().ToString(), c);
            Console.WriteLine("d type:{0}, value:{1}", d.GetType().ToString(), d);
            // c type:System.String, value:abc
            // d type:System.String, value:def

            // 사실 GetType() 메서드와 ToString() 메서드는 System.Int32와 int,
            // System.String과 string 형식이 object 형식으로부터 물려받아 갖고 있는 것
        }
    }
}
