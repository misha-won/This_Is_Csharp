// 5.1.3 switch 문

// switch 문과 패턴 매칭

namespace _04_Switch2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 형식 패턴(Type Pattern) 1

            // switch 문은 형식 패턴을 이용하여 데이터 형식에 따라서도 분기한다.

            object obj = 123;
            // C# 컴파일러는 123 리터럴을 평가하여 int 형식임을 유추하고,
            // obj 안에 박싱해 넣는다.

            switch (obj)
            {
                case int:
                    break;
                // obj에 담겨 있는 데이터의 형식이 int이므로,
                // 프로그램은 이 case 절을 따라 분기한다.
                case float:
                    break;
                default:
                    break;
            }

            #endregion 형식 패턴(Type Pattern) 1

            #region 형식 패턴(Type Pattern) 2

            object o = null;

            string? s = Console.ReadLine();
            if (int.TryParse(s, out int out_i))
                o = out_i;
            else if (float.TryParse(s, out float out_f))
                o = out_f;
            else
                o = s;

            // Parse : 변환이 실패하면 예외(Exception)을 던져서(Throw), 프로그램이
            // 현재 코드의 실행을 멈추고 흐름을 다른 곳으로 이동시킴
            // TryParse : 변환의 성공 여부를 반환하므로 현재의 코드 흐름 유지 가능

            switch (o)
            {
                case int:
                    Console.WriteLine($"{(int)o}은(는) int 형식입니다.");
                    break;
                case float:
                    Console.WriteLine($"{(float)o}은(는) float 형식입니다.");
                    break;
                default:
                    Console.WriteLine($"{o}은(는) 알 수 없는 형식입니다.");
                    break;
            }

            // 123은(는) int 형식입니다.

            // 123.45은(는) float 형식입니다.

            // 안녕하세요은(는) 알 수 없는 형식입니다.

            #endregion 형식 패턴(Type Pattern) 2
        }
    }
}
