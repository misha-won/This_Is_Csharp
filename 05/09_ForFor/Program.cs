// 5.2.4 중첩 for

// for 문은 while 문이나 do while 문보다 반복 제어를 위한 장치가 더 잘 갖춰져 있기 때문에,
// 꼭 반복문을 겹쳐서 사용해야 한다면 가장 적합한 후보라 할 수 있다.

namespace _09_ForFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // *
            // **
            // ***
            // ****
            // *****
        }
    }
}
