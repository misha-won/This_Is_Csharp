// 5.1.3 switch 문
namespace _04_Switch2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 형식 패턴(Type Pattern)

            // switch 문과 패턴 매칭
            // switch 문은 형식 패턴을 이용하여 데이터 형식에 따라서도 분기한다.

            object obj = 123;
            // C# 컴파일러는 123 리터럴을 평가하여 int 형식임을 유추하고 obj 안에 박싱해 넣는다.

            switch (obj)
            {
                case int:
                    break;
                // obj에 담겨 있는 데이터의 형식이 int이므로, 프로그램은 이 case 절을 따라 분기한다.
                case float:
                    break;
                default:
                    break;
            }

            #endregion 형식 패턴(Type Pattern)

            #region 형식 패턴(Type Pattern)과 케이스 가드(Case Guard)

            // 케이스 가드(Case Guard)
            // - switch 문에서 case 절의 패턴을 더 구체적으로 만들어 주는 추가적인 조건 검사이다.
            // - case 절의 뒤에 when 절을 붙여 사용한다.
            // - if 문처럼 bool 형식의 결과가 나오는 식을 입력받는다.

            object o = null;

            string? s = Console.ReadLine();
            if (int.TryParse(s, out int out_i))
                o = out_i;
            else if (float.TryParse(s, out float out_f))
                o = out_f;
            else
                o = s;

            // Parse : 변환이 실패하면 예외(Exception)을 던져지므로(Throw)
            //         프로그램이 현재 코드의 실행을 멈추고 흐름을 다른 곳으로 이동시킨다.

            // TryParse : 변환의 성공 여부를 반환하므로 현재의 코드 흐름을 유지할 수 있다.

            switch (o)
            {
                case int:
                    Console.WriteLine($"{(int)o}은(는) int 형식입니다.");
                    break;
                case float f when f >= 0:   // o가 float 형식이며 0보다 크거나 같은 경우
                    Console.WriteLine($"{f}은(는) 양의 float 형식입니다.");
                    break;
                case float:                 // o가 float 형식이며 0보다 작은 경우
                    Console.WriteLine($"{(float)o}은(는) 음의 float 형식입니다.");
                    break;
                default:
                    Console.WriteLine($"{o}은(는) 알 수 없는 형식입니다.");
                    break;
            }

            // 123은(는) int 형식입니다.

            // 123.45은(는) float 형식입니다.

            // 안녕하세요은(는) 알 수 없는 형식입니다.

            #endregion 형식 패턴(Type Pattern)과 케이스 가드(Case Guard)
        }
    }
}
