using System;

namespace _04_Overflow
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            uint a = uint.MaxValue;

            Console.WriteLine(a);   // 4294967295

            a = a + 1;

            Console.WriteLine(a);   // 0

            // VITAMIN QUIZ 3-2
            // uint 대신에 int를 사용하고 uint.MaxValue 대신에 int.MaxValue를 사용하면 어떤 결과가 나올까?
            // 2147483647
            // -2147483648
        }
    }
}
