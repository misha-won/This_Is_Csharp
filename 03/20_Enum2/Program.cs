using System;

namespace _20_Enum2
// enum은 변수가 아니고 새로운 형식이다!
{
    internal class Program
    {
        enum DialogResult { YES, NO, CANCEL, CONFIRM, OK }
        // DialogResult라는 새로운 형식을 만들었다.

        static void Main(string[] args)
        {
            DialogResult result = DialogResult.YES;
            // result는 DialogResult 형식인 변수이다.

            Console.WriteLine(result == DialogResult.YES);      // True
            Console.WriteLine(result == DialogResult.NO);       // False
            Console.WriteLine(result == DialogResult.CANCEL);   // False
            Console.WriteLine(result != DialogResult.CONFIRM);  // False
            Console.WriteLine(result != DialogResult.OK);       // False
        }
    }
}
