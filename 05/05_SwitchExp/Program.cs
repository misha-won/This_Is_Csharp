// 5.1.4 switch 식

// 식(Expression)
// - 결과값을 만들어낼 수 있는 연산자와 연산자의 조합이다.
// - 계산을 해서 결과를 내놓는다.
// - 반면에 문(Statement)은 결과의 유무에 관계없이 기능한다.

namespace _05_SwitchExp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("점수를 입력하십시오.");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int score))
                score = Convert.ToInt32(input);
            else
            {
                Console.WriteLine("점수는 정수 형식이어야 합니다.");
                return;
            }

            Console.WriteLine("재수강입니까? (Y/N)");
            string? line = Console.ReadLine();
            bool repeated = line == "Y" ? true : false;

            string grade = ((int)Math.Truncate(score / 10.0) * 10) switch
            {
                90 when repeated == true => "B+",
                90 => "A",
                80 => "B",
                70 => "C",
                60 => "D",
                _ => "F"
            };

            Console.WriteLine($"학점 : {grade}");

            // 점수를 입력하십시오.
            // 92
            // 재수강입니까? (Y/N)
            // N
            // 학점 : A

            // 점수를 입력하십시오.
            // 98
            // 재수강입니까? (Y/N)
            // Y
            // 학점 : B+
        }
    }
}
