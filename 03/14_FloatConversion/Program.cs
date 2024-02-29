using System;

namespace _14_FloatConversion
// 크기가 서로 다른 부동 소숫점 형식 사이의 변환
// float와 double 사이의 형식 변환에서는 오버플로가 발생하지 않지만,
// 데이터의 정밀성에는 손상을 입게 된다.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 69.6875f;
            Console.WriteLine("a : {0}", a);    // a : 69.6875

            double b = (double)a;
            Console.WriteLine("b : {0}", b);    // b : 69.6875

            Console.WriteLine("69.6875 == b : {0}", 69.6875 == b);  // 69.6875 == b : True

            float x = 0.1f;
            Console.WriteLine("x : {0}", x);    // x : 0.1

            double y = (double)x;
            Console.WriteLine("y : {0}", y);    // y : 0.10000000149011612

            Console.WriteLine("0.1 == y : {0}", 0.1 == y);          // 0.1 == y : False
        }
    }
}
