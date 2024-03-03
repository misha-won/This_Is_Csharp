// 5.1.3 switch 문
// 조건식의 결과가 가질 수 있는 다양한 경우를 한 번에 평가하고 프로그램의 흐름을 가를 때 사용한다.

#region switch 절 1
// switch (조건식(키워드))
// {
       #region switch 절 2
//     case 패턴1: (switch 레이블)
//         실행할_코드;
//         break; (break 문)
       #endregion switch 절 2
//     case 패턴2:
//         실행할_코드;
//         break;
//     case 패턴N:
//         실행할_코드;
//         break;
//     default:
//         실행할_코드;
//         break;
// }
#endregion switch 절 1

// case 절이나 default 절에서 사용된 break 문은 각 switch 절에서 실행 중이던 흐름을
// switch 문 바깥으로 옮긴다.

// 필요에 따라서는 break 문 대신 goto나 return, throw와 같은 점프문을 사용하는 것이
// 문법적으로 허용되기도 한다.

namespace _03_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("요일을 입력하세요(일, 월, 화, 수, 목, 금, 토) : ");
            string? day = Console.ReadLine();

            switch (day)
            {
                case "일":
                    Console.WriteLine("Sunday");
                    break;
                case "월":
                    Console.WriteLine("Monday");
                    break;
                case "화":
                    Console.WriteLine("Tuesday");
                    break;
                case "수":
                    Console.WriteLine("Wednesday");
                    break;
                case "목":
                    Console.WriteLine("Thursday");
                    break;
                case "금":
                    Console.WriteLine("Friday");
                    break;
                case "토":
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다");
                    break;
            }
        }

        // 요일을 입력하세요(일, 월, 화, 수, 목, 금, 토) : 화
        // Tuesday

        // 요일을 입력하세요(일, 월, 화, 수, 목, 금, 토) : 사
        // 잘못된 입력입니다
    }
}
