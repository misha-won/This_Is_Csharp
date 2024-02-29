using System;

namespace _09_Multiline
// 큰따옴표를 세 개 붙여 쓰면("""...""")
// 이스케이프 문자(\n) 없이도 여러 줄로 이어진 문자열 리터럴을 만들 수 있다.
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            string multiline = """
                별 하나에 추억과
                별 하나에 사랑과
                별 하나에 쓸쓸함과
                별 하나에 동경과
                별 하나에 시와
                별 하나에 어머니, 어머니
                """;

            Console.WriteLine(multiline);
        }
    }
}
