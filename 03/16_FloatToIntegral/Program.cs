using System;

namespace _16_FloatToIntegral
// float->int 강제 형변환은 반올림이 아니라 버림!
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 0.9f;
            int b = (int)a;
            Console.WriteLine(b);   // 0

            float c = 1.1f;
            int d = (int)c;
            Console.WriteLine(d);   // 1
        }
    }
}
